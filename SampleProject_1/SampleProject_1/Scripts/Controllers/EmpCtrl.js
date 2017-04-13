//Seperate each angular controller to make our code Managable & Seperable
angular.module('myApp') //extending from previously created angular module
                   .controller("EmpCtrl", function ($scope, empservice) { //create a Employee controller 
                       $scope.employees = null;
                       empservice.GetEmp().then(function (result) {
                           $scope.employees = result.data; // Success
                           console.log(result);
                       }, function () {
                           alert('Failed'); //failed
                       });
                   })
                   .factory('empservice', function ($http) { //create and configure service using factory
                       var fac = {};
                       fac.GetEmp = function () {
                           return $http.get("/Employee/GetEmployee");
                       }
                       return fac;
                   });