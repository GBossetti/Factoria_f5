<%@ Page Title="" Language="C#" MasterPageFile="~/WebApp.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Listado de imágenes</h1>

    <div class="row row-cols-1 row-cols-md-3 g-4">

        <%
            foreach (Dominio.Imagen imagen in listaImagen)
            {
        %>
            <div class="col">
                <div class="card h-100" style="width: 18rem;">
                    <img src="./Imagenes/<%: imagen.Directorio %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%:imagen.Titulo %></h5>
                        <div class="d-grid mx-auto">
                            <a href="#" class="card-link">Editar</a>
                        </div>
                        <div class="d-grid mx-auto">
                            <a href="#" class="card-link">Eliminar</a>
                        </div>
                    </div>
                </div>
            </div>
        
        <%  } %>
    </div>
</asp:Content>
