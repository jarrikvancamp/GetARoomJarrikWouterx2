(function () {
    'use strict';

    angular
        .module('getARoom')
        .controller('main', main);

    function main($http) {

        var self = this;

        $http.get('http://localhost:61000/api/review').
      success(function (data) {
          self.reviews = data;
      });

    }
})(); 
