(function () {

    function DataFactory($http, $q) {

        return {
            addUser: function (user) {e
                var deferred = $q.defer();


                $http.post('http://localhost:49579/api/User/AddUser', user, { headers: { 'Content-Type': 'application/json' } }).success(function (data) {
                   
                    deferred.resolve(data);
                }).error(deferred.resolve);

                return deferred.promise;
            },
            GetCities: function () {
                var deferred = $q.defer();
                $http.get('http://localhost:49579/api/User/GetCities', { headers: { 'Content-Type': 'application/json' } }).success(function (data) {

                    deferred.resolve(data);
                }).error(deferred.resolve);

                return deferred.promise;
            }
        }
    };


    angular.module("bookLibrary.factories").factory("DataFactory", ["$http", "$q", DataFactory])
})();