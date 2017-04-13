(function () {
    //create a module
    var myApp = angular.module('myApp', [])
    //Create a Controller
                      .controller("Emp", function ($scope) { //create a Employee controller 
                         //$scope used for share dat between Ctrl and View
                         $scope.Message = "I will go to View by Message Property"; 
                       });
             })();