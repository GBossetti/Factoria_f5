<%@ Page Title="" Language="C#" MasterPageFile="~/WebApp.Master" AutoEventWireup="true" CodeBehind="CargarImg.aspx.cs" Inherits="WebApp.CargarImg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>CARGAR IMAGEN</h1>
    <div class="row">

        <div class="col-md-4">
            <div class="mb-3">
                <label class="form-label">Título</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtTitulo" />
            </div>
            <div class="mb-3">
                <label class="form-label">Imagen</label>
                <input type="file" id="txtImagen" runat="server" class="form-control" />
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <asp:Button ID="btnGuardar" Text="Guardar" runat="server" OnClick="btnGuardar_Click"/>
            <a href="/">Cancelar</a>
        </div>
    </div>


</asp:Content>
