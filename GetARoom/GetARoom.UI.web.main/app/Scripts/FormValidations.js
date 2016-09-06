app.controller('validateDate', function ($scope) {
    if ($scope.arrival > $scope.departure) {
        $scope.IsWouter = true;
        return false;
    }
    $scope.IsWouter = true;
});