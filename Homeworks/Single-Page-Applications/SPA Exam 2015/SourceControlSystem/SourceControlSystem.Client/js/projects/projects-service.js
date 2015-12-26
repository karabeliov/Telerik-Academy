(function(){
    'use strict';

    function projects(data) {
        var PROJECTS_URL = 'api/projects';

        function getPublicProjects() {
            return data.get(PROJECTS_URL);
        }

        function filterProjects(filters) {
            return data.get(PROJECTS_URL, filters);
        }

        function createProjects(projects) {
            return data.post(PROJECTS_URL, projects);
        }

        return {
            getPublicProjects: getPublicProjects,
            createProjects: createProjects,
            filterProjects: filterProjects
        }
    }

    angular.module('myApp.services')
        .factory('projects', ['data', projects])
}());