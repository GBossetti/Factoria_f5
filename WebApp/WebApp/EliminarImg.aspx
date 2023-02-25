<%@ Page Title="" Language="C#" MasterPageFile="~/WebApp.Master" AutoEventWireup="true" CodeBehind="EliminarImg.aspx.cs" Inherits="WebApp.EliminarImg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <% if (!eliminado)
        { %>
        <p>¿Seguro que desea eliminar la imagen?</p>
        <asp:Button ID="btnAceptar" Text="Aceptar" runat="server" OnClick="btnAceptar_Click"/>
        <a href="Default.aspx">Cancelar</a>
    <%  }
        else
        {%>
        <p>Imagen eliminada con éxito</p>
        <a href="Default.aspx">Aceptar</a>
        <%} %>

</asp:Content>
