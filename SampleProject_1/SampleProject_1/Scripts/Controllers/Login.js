angular.module('myApp')
        .controller("LoginCtrl", function ($scope, LoginService) {
                $scope.IsLoggedIn =false;
                $scope.Message =' ';
                $scope.Submitted =false;
                $scope.IsFormValid=false;

                $scope.LoginData={
                       Username:'',
                       Password:''
                };

                //Check is Form valid or not // here f1.$valid is a formName
                $scope.$watch('f1.$valid', function(newVal){
                $scope.IsFormValid =newVal;
                });

                $scope.Login =function(){
                  $scope.Submitted=true;
                  if($scope.IsFormValid){
                    LoginService.GetUser($scope.LoginData).then(function(d){
                      if (d.data.UserName != null){
                          $scope.IsLoggedIn = true;                        
                          $scope.Message="Successfully Logged, How are you? "+ d.data.FullName;
                       }
                       else {
                        alert('Invalid Credentials');
                       }
                    });
                  }
                };
          })
          .factory('LoginService', function($http){
             var fac ={};
             fac.GetUser=function(d){
               return $http({
                 url: '/Employee/LoginDetailsCtrl',
                 method: 'POST',
                 data: JSON.stringify(d),
                 headers:{'content-type' : 'application/json'}
               });
             };
          return fac;
          });