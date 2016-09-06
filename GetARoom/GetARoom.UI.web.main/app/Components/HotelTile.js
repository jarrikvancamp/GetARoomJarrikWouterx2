app.component('hotelTile', {
    templateUrl: '../html/hotel.html',
    controller: 'hotelController'
});


app.controller('hotelController', function ($scope) {
    $scope.HotelName = "Jarrik's Hotel";
    $scope.HotelLocation = "Mechelen";
    $scope.HotelRating = 5;
});