(function () {


    function mainController($scope, $location, DataFactory) {
        $scope.currentUser = DataFactory.getCurrentUser();

        if ($scope.currentUser == null) {
            $location.path('/login')

        }

    }

    angular.module("bookLibrary.controllers").controller("mainController", ["$scope", "$location", "DataFactory", mainController]);


})();