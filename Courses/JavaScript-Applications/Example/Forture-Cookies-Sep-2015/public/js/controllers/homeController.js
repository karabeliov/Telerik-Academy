import 'jquery'
import data from 'js/data.js'
import templates from 'js/templates.js'
import notifier from 'js/notifier.js'

export default {
  all: function(context) {
      templates.load('cookies')
          .then(function(templateHtml) {
            var dates = data.cookies.all().then(
              (value) => {console.log(value.result.map((item) => {
                  $('#main').html(JSON.stringify(item));
              }));}
            );
    })
  }
}
