angular.module('getARoom').controller('IndexController', IndexController);

IndexController.$inject = ['$http'];

function IndexController($http) {
    var vm = this;
    vm.items = [];
    function getItems() {

        $http({ method: 'GET', url: 'http://localhost:61560/TopHotels'})
            .success(function (data, status) {
                
                vm.items = data;
            })
            .error(function (data, status) {
                alert("Error");
            });
    };

    getItems();
}