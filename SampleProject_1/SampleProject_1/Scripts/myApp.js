/// <reference path="angular.js" />
var myApp = angular.module('myApp', [])
                   .controller("EmpCtrl", function ($scope, $http) {
                       $scope.employees = "";
                       $http.get("/Employee/GetEmployee1")
                       .then (function (result) {
                           $scope.employees = result.data; // Success
                           console.log(result);
                       }, function () {
                           alert('Failed'); //failed
                       });
                   });