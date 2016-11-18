<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Areas.aspx.cs" Inherits="Administracion_Areas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../Scripts/jquery-2.2.2.js"></script>
    <script type="text/javascript" src="../Scripts/Angular/angular.js"></script>
    <script src="../Scripts/Angular/angular-animate.js"></script>
    <script src="../Scripts/Angular/angular-messages.js"></script>
    <script src="../Scripts/Angular/angular-aria.js"></script>
    <script src="../Scripts/bootstrap.js"></script>
    <script src="http://ajax.aspnetcdn.com/ajax/4.0/1/MicrosoftAjax.js"></script>
    

    <link href="../Styles/bootstrap/css/bootstrap.css" rel="stylesheet" />
    <script src="../Scripts/ui-bootstrap-tpls-2.0.0.js"></script>

    <script src="../Scripts/jsApp/appAreas.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div ng-app="myApp" ng-controller="areaController">
        <div ng-repeat="ar in lstASeleccionada"><label ng-model="lRuta" ng-bind="ar.Ruta_Texto"></label></div>
        Seleccione el área:
        <select ng-model="Area" ng-change="Consultar();" ng-options="a.Descripcion for a in lstAreas track by u.Id" required="required">
            
        </select>
        <br />
        <button type="button" ng-show="!vAreas" ng-model="bNuevaArea" ng-click="ShowHideNuevaArea();" class="btn btn-link">Agregar nueva área</button>
        <div id="dNuevaArea" ng-show="vAreas">
            <table id="tbNuevaArea" class="table table-bordered table-condensed table-responsive">
                <thead>
                    <tr>
                        <th colspan="3">Agregar una nueva Área</th>
                    </tr>
                    <tr>
                        <th>Clave</th>
                        <th>Siglas</th>
                        <th>Descripción</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            <input type="text" placeholder="Ingresa la Clave del área o departamento" ng-model="tClave" class="form-control"/>
                        </td>
                        <td>
                            <input type="text" placeholder="Ingresa las Siglas" ng-model="tSiglas" class="form-control"/>
                        </td>
                        <td>
                            <input type="text" placeholder="Ingresa una Descripción" ng-model="tDescripcion" class="form-control"/>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td>
                            <button type="button" class="btn btn-primary" ng-click="GuardaArea();">Aceptar</button>
                            <button type="button" ng-click="ShowHideNuevaArea();" class="btn btn-danger">Cancelar</button>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>

        <div>
            <table>
                <thead>
                    <tr>
                        <th>Clave</th>
                        <th>Siglas</th>
                        <th>Descripción</th>
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat="area in lstAreas">
                        <td>
                            <label ng-bind="area.Clave"></label>
                        </td>
                        <td>
                            <label ng-bind="area.Siglas"></label>
                        </td>
                        <td>
                            <label ng-bind="area.Descripcion"></label>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>

