<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-2.2.2.js"></script>
    <script type="text/javascript" src="Scripts/Angular/angular.js"></script>
    <script src="Scripts/Angular/angular-animate.js"></script>
    <script src="Scripts/Angular/angular-messages.js"></script>
    <script src="Scripts/Angular/angular-aria.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="http://ajax.aspnetcdn.com/ajax/4.0/1/MicrosoftAjax.js"></script>
    

    <link href="Styles/bootstrap/css/bootstrap.css" rel="stylesheet" />

    <script src="Scripts/ui-bootstrap-tpls-2.0.0.js"></script>
    <script src="http://ajax.aspnetcdn.com/ajax/4.0/1/MicrosoftAjax.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div ng-app="myApp" ng-controller="Controller">
        <table>
            <tr ng-repeat="i in items">
                <td ng-bind="i.columna1"></td>
                <td ng-bind="i.columna2"></td>
                <td ng-bind="i.columna3"></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
