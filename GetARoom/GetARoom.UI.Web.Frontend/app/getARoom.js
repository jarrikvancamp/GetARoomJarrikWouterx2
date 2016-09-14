(function () {
    'use strict';

    angular.module('getARoom', ['ui.bootstrap', 'ui.router']).config(['$stateProvider', '$urlRouterProvider',
        function ($stateProvider, $urlRouterProvider) {

        $stateProvider.state('home', {
            url: '/',
            templateUrl: 'app/html/indexView.html',
            controller: 'IndexController',
            controllerAs: 'vm'
        })
            .state('hotels', {
                url: '/hotels',
                templateUrl: 'app/html/hotelView.html',
                controller: 'SearchController',
                controllerAs: 'vm'
            })
              .state('hotelDetails', {
                  url: '/hotels/:hotelid',
                  templateUrl: 'app/html/detailsView.html',
                  controller: 'DetailsController',
                  controllerAs: 'vm'
              })
               .state('about', {
                   url: '/about',
                   templateUrl: 'app/html/aboutView.html',
                   controller: 'AboutController'
               })
              .state('login', {
                  url: '/login',
                  templateUrl: 'views/login.view.html'
              });
    }]);;
})();