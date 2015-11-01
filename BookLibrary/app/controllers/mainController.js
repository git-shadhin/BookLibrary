(function () {


    function mainController($scope){
    $scope.name = "daniel yaakove";
    }

    angular.module("bookLibrary.controllers").controller("mainController",["$scope", mainController]);


})();