namespace $safeprojectname$ {

    angular.module('$safeprojectname$', ['ngRoute'])
        .config(function ($routeProvider: ng.route.IRouteProvider) {

            $routeProvider.when('/', { template: 'Hello World' });
        });
}