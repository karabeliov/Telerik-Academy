import Sammy from 'sammy'
import 'jquery'
import usersController from 'js/controllers/usersController.js'
import homeController from 'js/controllers/homeController.js'
import myCookiesController from 'js/controllers/myCookiesController.js'

var containerId = '#main';
var sammyApp = Sammy(containerId, function() {
    this.get('#/', function() {
        this.redirect('#/home');
    });

    this.get('#/register', usersController.register);
    this.get('#/login', usersController.login);
    this.get('#/logout', usersController.logout);

    this.get('#/home', homeController.all);
    this.get('#/mycookies', myCookiesController.all);
    this.get('#/mycookies/add', myCookiesController.add);
});

sammyApp.run('#/');
