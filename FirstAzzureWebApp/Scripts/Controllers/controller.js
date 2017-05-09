var app = angular.module('MyApp', ['ngMask'])
app.controller('MyController', function ($scope, $http, $window) {

    $scope.ButtonClick = function () {
        console.log($scope.reqPhoneNumber);
        $scope.Results = false;
        $scope.NoResults = false;
        $http({
            method: "POST",
            url: "/Ajax/getCustomerByPhone",
            dataType: 'json',
            data: { phoneNumber: $scope.reqPhoneNumber },
            headers: { "Content-Type": "application/json" }
        }).then(function successCallback(response) {
            console.log(response);
            var data = response.data;
            if (data == "NA") {
                $scope.NoResults = true;
            } else {
                $scope.firstName = data.FirstName;
                $scope.lastName = data.LastName;
                $scope.phoneNumber = data.phoneNumber;
                $scope.email = data.email;
                $scope.Results = true;
            }
        }, function errorCallback(response) {
            console.log(response);
            $scope.NoResults = true;
        });
    }
});