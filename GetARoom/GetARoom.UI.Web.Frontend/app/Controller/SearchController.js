angular.module('getARoom').controller('SearchController', SearchController);

SearchController.$inject = ['$http'];

function SearchController($http) {
    var vm = this;
    vm.items = [];
    function getItems() {

        $http({ method: 'GET', url: 'http://localhost:61000/api/hotel' })
            .success(function (data, status) {
                vm.items = data;
            })
            .error(function (data, status) {
                alert("Error");
            });
    };
    getItems();
}