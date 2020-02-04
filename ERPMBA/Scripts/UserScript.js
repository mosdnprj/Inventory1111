var app = angular.module("myApp", []);

app.controller('MyAppUsers',
function ($scope) {
    $scope.Puserid = "1";
    $scope.setid = function ($Getid) {
        $scope.Puserid = $Getid;;
    }
});
app.controller("Userctrl", function ($scope, $http) {

    $scope.userDetails = "";
    $http.get("/user/GetUserInfo")
    .success(function (result) {
        $scope.userDetails = result;
    })
    .error(function(result){
        consol.log(result);
    });
});