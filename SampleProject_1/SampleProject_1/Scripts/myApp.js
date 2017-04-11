/// <reference path="angular.js" />
var myApp = angular.module('myApp', [])
                   .controller("EmpCtrl", function ($scope, $http) {
                       $scope.employees = "";
                       $http.get("/Employee/GetEmployee")
                       .then (function (result) {
                           $scope.employees = result.data;
                           console.log(result);
                       });
                   });