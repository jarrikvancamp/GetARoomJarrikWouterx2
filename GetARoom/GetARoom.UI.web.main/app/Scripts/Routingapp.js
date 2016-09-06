var app = angular.module('routing', ['ui.router']);

app.config(function ($stateProvider) {
    var helloState = {
        name: 'hotels',
        url: '/hotels',
        templateUrl: '../html/hotellist.html'
    }

    var aboutState = {
        name: 'about',
        url: '/about',
        template: '<h3>Its the UI-Router hello world app!</h3>'
    }

    var hotelState = {
        name: 'hotel',
        url: '/hotel?id',
        templateUrl: '../html/viewhotel.html',
        controller: 'viewHotelController'
    }


    $stateProvider.state(helloState);
    $stateProvider.state(aboutState);
    $stateProvider.state(hotelState);
});