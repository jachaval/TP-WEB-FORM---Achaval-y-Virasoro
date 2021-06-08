<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AplicacionaWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mx-auto m-5" style="width: 200px;">
        <h1>Productos</h1>
    </div>

    <div class="buscador">
        <form class="form-inline";>
        <asp:TextBox ID="txtBuscado" placeholder="Que Buscas?" class="form-control mb-2 mr-sm-2" style="width: 200px" runat="server" />
        <asp:Button Text="Buscar" class="btnBuscar" ID="btnBuscar" OnClick="btnBuscar_Click" CommandArgument="txtBuscado" runat="server"/>
            <%--<a href="#" OnClick="btnbuscarClick" class="btn btn-primary">Buscar</a>--%>
        </form>
        
    </div>
        <div class="container">
        <div class="row">
            <% foreach (Dominio.Articulo item in lista) 
               {%>
                <div class="col mb-3 col-md-4 ">
                    <div class="card" style="width: 18rem;">
                        <img src="<% = item.UrlImagen %>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title"><% = item.Nombre %></h5>
                            <p class="card-text"><% = item.Precio.ToString("C",new System.Globalization.CultureInfo("en-US")) %></p>
                            <a href="Carrito.aspx?id=<% = item.Id %>" class="btn btn-primary">Agregar al Carrito</a>
<%--                            <a href="Carrito.aspx?id=<% = item.Id %>&e=t"><i class="fas fa-heart"></i></a>--%>
                        </div>
                    </div>
                </div>
            <% } %>
        </div>
    </div>
</asp:Content>
