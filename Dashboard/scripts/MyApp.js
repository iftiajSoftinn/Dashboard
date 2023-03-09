(function () {
    //Model 
    var app = angular.module('MyApp', ['ngRoute']);

    //Controller
    app.controller('HomeController', funnction($scope)) {
        $scope.Message = "It worked";
    });
})();

