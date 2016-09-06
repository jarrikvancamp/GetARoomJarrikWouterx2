app.controller('viewHotelController', function ($http,$scope, $stateParams) {
    $http.get('http://localhost:61000/api/hotel/' + $stateParams.id)
     .then(function (response) { $scope.hotels = response.data; });

    $http.get('http://localhost:61000/api/ReviewViewModel/' + $stateParams.id)
     .then(function (response) { $scope.reviews = response.data; });
});