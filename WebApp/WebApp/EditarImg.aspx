<%@ Page Title="" Language="C#" MasterPageFile="~/WebApp.Master" AutoEventWireup="true" CodeBehind="EditarImg.aspx.cs" Inherits="WebApp.EditarImg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Editar Imagen</h1>

    <div class="col-md-4">
        <div class="mb-3">
            <label class="form-label">Título</label>
            <asp:TextBox ID="txtTitulo" runat="server" />  
        </div>
    </div>
    <div class="col-md-4">
        <asp:Image ID="imgImagen" runat="server" CssClass="img-fluid mb-3" AlternateText="Imagen inexistente"/>
    </div>

    <div class="row">
        <div class="col-6">
            <asp:Button ID="btnGuardar" Text="Guardar" runat="server" OnClick="btnGuardar_Click" />
            <a href="Default.aspx">Cancelar</a>
        </div>
    </div>


</asp:Content>
