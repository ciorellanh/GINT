var app = angular.module('myApp', []);

app.controller('areaController', function ($scope, $http) {
    $scope.Area = '';
    $scope.UsuarioActual = function () {
        var httpreq = {
            method: 'POST',
            url: 'Areas.aspx/UsuarioActivo',
            headers: {
                'Content-Type': 'application/json; charset=utf-8',
                'dataType': 'json'
            },
            data: {}
        }
        $http(httpreq).success(function (response) {
            $scope.lstUsuarios = response.d;
            $scope.Area = $scope.lstUsuarios[0].IdArea;
            alert($scope.lstUsuarios[0].IdArea);
        })
    };

    

    $scope.Dependencias = function () {
        var httpreq = {
            method: 'POST',
            url: 'Areas.aspx/Consultar_Todas',
            headers: {
                'Content-Type': 'application/json; charset=utf-8',
                'dataType': 'json'
            },
            data: { pUbicacion: $scope.Area }
        }
        $http(httpreq).success(function (response) {
            $scope.lstAreas = response.d;
        })
    };

    $scope.AreaSeleccionada = function () {
        var httpreq = {
            method: 'POST',
            url: 'Areas.aspx/Consultar_xClave',
            headers: {
                'Content-Type': 'application/json; charset=utf-8',
                'dataType': 'json'
            },
            data: { pClave: $scope.Area }
        }
        $http(httpreq).success(function (response) {
            $scope.lstASeleccionada = response.d;
        })
    };

    $scope.tClave = "";
    $scope.tSiglas = "";
    $scope.tDescripcion = "";
    $scope.lRuta = "";
    $scope.GuardaArea = function () {
        var httpreq = {
            method: 'POST',
            url: 'Areas.aspx/NuevaArea',
            headers: {
                'Content-Type': 'application/json; charset=utf-8',
                'dataType': 'json'
            },
            data: {
                pPadre: $scope.Area,
                pClave: $scope.tClave,
                pSiglas: $scope.tSiglas,
                pDescripcion: $scope.tDescripcion,
                pRuta: $scope.lRuta,
                pRuta_Texto: $scope.lRuta
            }
        }
        $http(httpreq).success(function (response) {
            $scope.Consultar();
            alert("Área guardada.");
        })
    };

    $scope.Consultar = function () {

        $scope.Dependencias();
        $scope.AreaSeleccionada();
    };

    $scope.UsuarioActual();
    $scope.Consultar();

    $scope.vAreas = false;
    $scope.ShowHideNuevaArea = function () {
        //If DIV is visible it will be hidden and vice versa.
        $scope.vAreas = $scope.vAreas ? false : true;
    };
});
