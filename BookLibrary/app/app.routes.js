angular.module('bookLibrary').config(['$routeProvider', function ($routeProvider) {

	$routeProvider.
    when('/main', {
    	templateUrl: '/app/views/main.html',
    	controller: 'mainController'
    }).
    when('/register', {
    	templateUrl: '/app/views/register.html',
    	controller: 'registerController'
    }).
    otherwise({
    	redirectTo: '/main'
    });
}])