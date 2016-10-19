angular.module("myApp", ['ui.bootstrap']).controller("ctrlUsuarios", function ($scope, $http, $uibModal, $log) {
    $scope.Todos = function () {
        var httpreq = {
            method: 'POST',
            url: 'http://lesnxv8malbc2c34.pemex.pmx.com/svcGINT/Servicios.Usuarios.svc/Todos',
            headers: {
                'Content-Type': 'application/json; charset=utf-8',
                'dataType': 'json'
            },
            data: {}
        }
        $http(httpreq).success(function (response) {
            $scope.lstUsuarios = response.d;
        })
    };
    
    $scope.Todos();
});