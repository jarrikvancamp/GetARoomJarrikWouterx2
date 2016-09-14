(function () {
    'use strict';

    angular
        .module('getARoom')
        .controller('main', main);

    function main($window, $log, $http) {
        /* jshint validthis:true */
        var vm = this;
        vm.hotelsLoading = true;
        vm.hotelsLoaded = false;

        //// code komen om hotels uit database aan te roepen
        //$http.get('http://localhost:61560/hotels').then(function(response) {
        //    vm.hotels = response.data;
        //    vm.hotelsLoading = false;
        //    vm.hotelsLoaded = true;
        //});
    }     
})();
