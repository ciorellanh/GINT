var app = angular.module('myApp', []);

app.controller('areaController', function ($scope, $http) {
    var valorArea=0;
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
            valorArea = $scope.lstUsuarios[0].IdArea;
            $scope.Consultar($scope.lstUsuarios[0].IdArea);
        })
    };

    

    $scope.Dependencias = function (area) {
        var httpreq = {
            method: 'POST',
            url: 'Areas.aspx/Consultar_Todas',
            headers: {
                'Content-Type': 'application/json; charset=utf-8',
                'dataType': 'json'
            },
            data: { pUbicacion: area }
        }
        $http(httpreq).success(function (response) {
            $scope.lstAreas = response.d;
        })
    };

    $scope.AreaSeleccionada = function (area) {
        var httpreq = {
            method: 'POST',
            url: 'Areas.aspx/Consultar_xClave',
            headers: {
                'Content-Type': 'application/json; charset=utf-8',
                'dataType': 'json'
            },
            data: { pClave: area }
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

    $scope.Consultar = function (area) {

        $scope.Dependencias(area);
        $scope.AreaSeleccionada(area);
    };

    $scope.UsuarioActual();
    

    $scope.vAreas = false;
    $scope.ShowHideNuevaArea = function () {
        //If DIV is visible it will be hidden and vice versa.
        $scope.vAreas = $scope.vAreas ? false : true;
    };
});
