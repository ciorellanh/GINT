﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Usuarios.aspx.cs" Inherits="Administracion_Usuarios" %>

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
    <script src="http://ajax.aspnetcdn.com/ajax/4.0/1/MicrosoftAjax.js"></script>

    <script src="../Scripts/jsApp/appUsuarios.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div ng-app="myApp" ng-controller="userController">
        <div id="dNuevoUsuario">
            <table id="tbNuevoUsuario">
                <thead>
                    <tr>
                        <th colspan="5">Agregar Nuevo Usuario</th>
                    </tr>
                    <tr>
                        <td>Cuenta</td>
                        <td>Clave</td>
                        <td>Nombre</td>
                        <td>Area</td>
                        <td>Telefono</td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            <input type="text" ng-model="tCuenta" />
                        </td>
                        <td>
                            <input type="text" ng-model="tClave" />
                        </td>
                        <td>
                            <input type="text" ng-model="tNombre" />
                        </td>
                        <td>
                            <select>
                                <option value="1">PEMEX</option>
                            </select>
                        </td>
                        <td>
                            <input type="text" ng-model="tTelefono" />
                        </td>
                    </tr>
                </tbody>
            </table>
            <button type="button" class="btn btn-primary" ng-click="Guarda_Usuario();"></button>
        </div>
        <table class="table table-striped table-condensed table-responsive table-bordered">
            <thead>
                <tr>
                    <td>
                        CUENTA
                    </td>
                    <td>
                        CLAVE
                    </td>
                    <td>
                        NOMBRE
                    </td>
                    <td>
                        ID_AREA
                    </td>
                    <td>
                        TELEFONO
                    </td>
                </tr>
            </thead>
            <tbody>
                <tr ng-repeat="usuario in lstUsuarios">
                    <td>
                        {{usuario.Cuenta}}
                    </td>
                    <td>
                        {{usuario.Clave}}
                    </td>
                    <td>
                        {{usuario.Nombre}}
                    </td>
                    <td>
                        {{usuario.Area}}
                    </td>
                    <td>
                        {{usuario.Telefono}}
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>

