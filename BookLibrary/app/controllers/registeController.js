(function () {



    function registerController($scope, DataFactory) {

        $scope.user = { ID: null, FirstName: "", LastName: "", Email: "", BirthDate: "", CityID: null, Street: null, UserName: "", Password: "" };
        $scope.cities = [];

        $scope.save = function () {
            $scope.$broadcast('show-errors-check-validity');

            if ($scope.registrationForm.$valid) {

                DataFactory.addUser(JSON.stringify($scope.user))
                alert('User saved');

            }
        };

        DataFactory.GetCities().then(function (data) {
            $scope.cities = data;

        });

        $scope.reset = function () {
            $scope.$broadcast('show-errors-reset');
            $scope.user = { name: '', email: '' };
        }

        $scope.selectedCity = {};
    }

    angular.module("bookLibrary.controllers").controller("registerController", ["$scope", "DataFactory", registerController]);


})();