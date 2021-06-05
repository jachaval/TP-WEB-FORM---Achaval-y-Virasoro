<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="AplicacionaWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h2>Carrito de Compras</h2>
    


    <div class="container">
        <div class="row">
            <% foreach (Dominio.Articulo item in ) 
               {%>
                <div class="col mb-3">
                    <div class="card" style="width: 18rem;">
                        <img src="<% = item.UrlImagen %>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <asp:Label Id="lblSeleccionado" runat="server"/>
    <asp:Label Id="lblUrlImagen" runat="server"/>
                        </div>
                    </div>
                </div>
            <% } %>
        </div>
    </div>

</asp:Content>
