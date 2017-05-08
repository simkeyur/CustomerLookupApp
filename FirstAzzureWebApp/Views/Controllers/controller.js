var app = angular.module('MyApp', [])
app.controller('MyController', function ($scope, $http, $window) {
    $scope.ButtonClick = function () {
        $scope.loading = false;
        var post = $http({
            method: "POST",
            url: "/Ajax/getCustomerByPhone",
            dataType: 'json',
            data: { phoneNumber: $scope.reqPhoneNumber },
            headers: { "Content-Type": "application/json" }
        });

        post.success(function (data, status) {
            $scope.firstName = data.FirstName;
            $scope.lastName = data.LastName;
            $scope.phoneNumber = data.phoneNumber;
            $scope.email = data.email;
            $scope.loading = true;
            //$window.alert("Hello: " + data.FirstName + " " + data.LastName);
        });

        post.error(function (data, status) {
            $window.alert(data.Message);
        });
    }
});