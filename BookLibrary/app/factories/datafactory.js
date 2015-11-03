(function () {

    function DataFactory($http, $q) {

        var currentUser = null;

        return {
            addUser: function (user) {
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
            },
            Login: function (UserName, Password) {
                var deferred = $q.defer();

                $http({
                    url: "http://localhost:49579/api/User/Login/" + UserName + "/" + Password,
                    method: "POST",
                    headers: { 'Content-Type': 'application/json' }
                }).success(function (data) {

                    currentUser = data;
                    deferred.resolve(data);
                }).error(deferred.resolve);

                return deferred.promise;
            },
            getCurrentUser: function () {
                return currentUser;
            }

        }
    };


    angular.module("bookLibrary.factories").factory("DataFactory", ["$http", "$q", DataFactory])
})();