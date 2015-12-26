(function () {
    'use strict';

    function CreateProjectsController($location, projects, notifier) {
        var vm = this;

        vm.createProjects = function (newProjects) {
            projects.createProjects(newProjects)
                .then(function (createdProjects) {
                    if (createdProjects) {
                        notifier.success('Your project is created!');
                        $location.path('/projects/' + createdProjects.Id);
                    }
                    else {
                        notifier.error('Form is not valid!');
                    }
                });
        }
    }

    angular.module('myApp.controllers')
        .controller('CreateProjectsController', ['$location', 'projects', 'notifier', CreateProjectsController]);
}());