<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AplicacionaWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mx-auto m-5" style="width: 200px;">
        <h1>Productos</h1>
    </div>
    
    <div class="container">
        <div class="row">
            <% foreach (Dominio.Articulo item in lista) 
               {%>
                <div class="col mb-3">
                    <div class="card" style="width: 18rem;">
                        <img src="<% = item.UrlImagen %>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title"><% = item.Nombre %></h5>
                            <p class="card-text"><% = item.Precio %></p>
                            <a href="#" class="btn btn-primary">Agregar al Carrito</a>
                        </div>
                    </div>
                </div>
            <% } %>
        </div>
    </div>

  <%--  <div class="card" style="width: 18rem;">
        <img src="<% = item.UrlImagen %>" class="card-img-top" alt="...">
        <div class="card-body">
            <h5 class="card-title">Card title</h5>
            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
            <a href="#" class="btn btn-primary">Go somewhere</a>
        </div>
    </div>--%>

</asp:Content>
