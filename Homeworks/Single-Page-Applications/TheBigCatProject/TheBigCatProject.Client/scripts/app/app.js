(function () {
    'use strict'

    function config($routeProvider, $locationProvider) {

        var CONTROLLER_VIEW_MODEL_NAME = 'vm';

        $locationProvider.html5Mode(true);

        $routeProvider
            .when('/', {
                templateUrl: 'parties/home/home.html',
                controller: 'HomeController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/identity/register', {
                templateUrl: 'parties/identity/register.html',
                controller: 'RegisterController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            //.when('/add', {

            //})
            .otherwise({ redirectTo: '/'})
    }

    angular.module('catApp.controllers', []);

    angular.module('catApp', ['ngRoute', 'catApp.controllers'])
        .config(['$routeProvider', '$locationProvider', config]);
}());