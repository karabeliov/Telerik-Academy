import 'jquery'
import data from 'js/data.js'
import templates from 'js/templates.js'
import notifier from 'js/notifier.js'

export default {
    all: function(sammy) {
        var text = +sammy.params['text'] || '',
            category = +sammy.params['category'] || '';

        Promise.all([data.cookies.all(), templates.load('home')])
            .then(function([data, template]) {
                $('#main').html(template({
                        text: data,
                        category: category
                    }
                ));
            });

        $('#main').on('click', '#btn-post', function(ev) {
            var text = $('#post-title')[0].value,
                category = $('#post-body')[0].value;

            data.cookies.add(text, category)
                .then(function(data) {
                    notifier.success(data);
                    sammy.redirect('#/');
                }, function(err) {
                    sammy.redirect('#/login');
                });
        })
    }
}
