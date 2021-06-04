<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="AplicacionaWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h2>Carrito de Compras</h2>

    <%foreach (Dominio.Articulo item in carrito)
        {%>
        <p><% =item.Nombre %></p>

            <%}%>
</asp:Content>
