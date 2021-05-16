<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmIinicio.aspx.cs" Inherits="Tarea10.frmIinicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="ButtonCargardatos" runat="server" OnClick="Button1_Click" Text="CARGAR DATOS" Width="644px" />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxIDE" runat="server" OnTextChanged="TextBoxIDE_TextChanged" style="margin-left: 0px" Width="472px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonID" runat="server" OnClick="ButtonID_Click" Text="Buscar por ID" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TestBoxNombre" runat="server" OnTextChanged="TestBoxNombre_TextChanged" Width="484px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="ButtonBuscarNombre" runat="server" OnClick="ButtonBuscarNombre_Click" Text="Buscar por Nombre" />
        <br />
    </form>
</body>
</html>
