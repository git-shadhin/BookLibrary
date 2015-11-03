(function () {


    function loginController($scope,$location ,DataFactory) {

        $scope.currentUser = { userName: "", password: "" };

        $scope.login = function () {

            $scope.$broadcast('show-errors-check-validity');

           // $scope.showError = true;

            if ($scope.loginForm.$valid) {

                DataFactory.Login($scope.currentUser.userName, $scope.currentUser.password).then(function (data) {
                   
                    if(data!=null)
                    {
                        $location.path('/main')
                    }


                });
            }

        }
       

        $scope.showError = false;


    }

    angular.module("bookLibrary.controllers").controller("loginController", ["$scope","$location","DataFactory", loginController]);


})();