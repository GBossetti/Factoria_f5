<%@ Page Title="" Language="C#" MasterPageFile="~/WebApp.Master" AutoEventWireup="true" CodeBehind="Papelera.aspx.cs" Inherits="WebApp.Papelera" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="dgvPapelera" runat="server" DataKeyNames="Id" CssClass="table table-dark table-bordered" OnSelectedIndexChanged="dgvPapelera_SelectedIndexChanged" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Título" DataField="Titulo" />
            <asp:BoundField HeaderText="Nombre Archivo" DataField="Directorio" />
            <asp:CommandField ShowSelectButton="true" SelectText="X" HeaderText="Seleccionar" />
        </Columns>
    </asp:GridView>

    <div class="col-4">
        <asp:Label ID="lblTitulo" runat="server" />
        <asp:Image ID="imgImagen" runat="server" CssClass="img-fluid mb-3" />
        <asp:Button ID="btnRestaurar" Text="Restaurar" runat="server" OnClick="btnRestaurar_Click" />
    </div>

</asp:Content>
