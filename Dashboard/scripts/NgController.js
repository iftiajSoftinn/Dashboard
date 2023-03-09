app.controller('MyController', function ($scope, $http) {
    $http.get('/api/ngdata')
        .then(function (response) {
            $scope.reservations = response.data;
        })
        .catch(function (error) {
            console.log(error);
        });
});
