angular.module('getARoom').controller('SearchController', SearchController);

function SearchController($http) {
    var vm = this;
    vm.items = [];
    function getItems() {

        $http({ method: 'GET', url: 'http://localhost:61560/hotels' })
            .success(function (data, status) {
                vm.items = data;
            })
            .error(function (data, status) {
                alert("Error");
            });
    };

    getItems();
}