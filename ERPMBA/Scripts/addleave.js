

var myApp1 = angular.module("myApp1", []);

myApp1.controller("AddLeavectrl", function ($scope, $http) {
    $scope.AddLeaveDetails = "";


    $http.get("/HR/GetAddLeaveInfo")
    .then(function (result) {
        $scope.AddLeaveDetails = result.data;
        $scope.editAdd = true;
        $scope.editupdate = false;


    })
    $scope.removeRec = function (User) {
        $http.post("/HR/DeleteAddLeave", User)
         .then(function (data) {
             location.reload();
             return response;


         })
    }
    $scope.NewInsert = {
        NewUsers: {}
    }
    $scope.EditRecord = function (User) {
        $scope.NewInsert.NewUsers.emplid = User.emplid;
        $scope.NewInsert.NewUsers.Department = User.Department;
        $scope.NewInsert.NewUsers.LeaveType = User.LeaveType;
        $scope.NewInsert.NewUsers.Other = User.Other;
        $scope.NewInsert.NewUsers.StartDate = User.StartDate;
        $scope.NewInsert.NewUsers.EndDate = User.EndDate;
        $scope.NewInsert.NewUsers.NoOfDays = User.NoOfDays;
        $scope.NewInsert.NewUsers.NoInLeave = User.NoInLeave;
        $scope.NewInsert.NewUsers.AplyDate = User.AplyDate;
        $scope.NewInsert.NewUsers.ResponsiblePerson = User.ResponsiblePerson;
        $scope.NewInsert.NewUsers.ContactAddress = User.ContactAddress;
        $scope.NewInsert.NewUsers.remarks = User.remarks;
        $scope.editupdate = true;
        $scope.editAdd = false;
        alert("Edit");
    }

    $scope.Submit = function () {
        $http.post("/HR/InsertAddLeave", $scope.NewInsert.NewUsers)
        .then(function (data) {
            location.reload();
            alert("Save Record");

        })
    }
    $scope.Update = function () {
        $http.post("/HR/UpdateAddLeave", $scope.NewInsert.NewUsers)
        .then(function (data) {
            location.reload();
            alert("Save Update");
            $scope.editAdd = true;
            $scope.editupdate = false;

        })
    }
});
