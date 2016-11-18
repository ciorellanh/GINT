var app = angular.module('myApp', []);


app.controller('userController', function ($scope, $http) {
    $scope.Area = 1;
    $scope.fillList = function () {
        var httpreq = {
            method: 'POST',
            url: 'Usuarios.aspx/Consultar_Todos',
            headers: {
                'Content-Type': 'application/json; charset=utf-8',
                'dataType': 'json'
            },
            data: {pUbicacion:$scope.Area}
        }
        $http(httpreq).success(function (response) {
            $scope.lstUsuarios = response.d;
        })
    };

    $scope.fillList();

    $scope.tCuenta="";
    $scope.tClave="";
    $scope.tNombre="";
    $scope.sArea="1";
    $scope.tTelefono = "";

    $scope.Guarda_Usuario = function () {
        var httpreq = {
            method: 'POST',
            url: 'Usuarios.aspx/Nuevo',
            headers: {
                'Content-Type': 'application/json; charset=utf-8',
                'dataType': 'json'
            },
            data: {
                pCuenta: $scope.tCuenta,
                pClave: $scope.tClave,
                pNombre:$scope.tNombre,
                pArea:$scope.sArea,
                pTelefono: $scope.tTelefono
            }
        }
        $http(httpreq).success(function (response) {
            $scope.fillList();
            alert("Usuario Agregado.");
        })
    };
});
    