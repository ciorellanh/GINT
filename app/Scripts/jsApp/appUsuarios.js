var app = angular.module('myApp', []);

app.service('sUsuarios', function ($http) {
    this.getAll()=function() {
        return $http.get('Usuarios.aspx/Consultar_Todos');
    }
});

app.controller('userController', function ($scope, $http, $log, sUsuarios) {
    $scope.todos();

    $scope.todos = function () {
        result = sUsuarios.getAll();
        result.then($scope.lstUsuarios, errorCallback);
    }

    
});