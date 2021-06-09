<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="AplicacionaWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mx-auto m-5" style="width: 600px;">
        <h1>Carrito de Compras</h1>
    </div>
        
    <table class="table">
        <tr>
            <td><b>Nombre</b></td>
            <td><b>Precio</b></td>
            <td><b>Acción</b></td>
        </tr>

        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Nombre")%></td>
                    <td><%#Eval("Precio") %></td>
                    <td>
                        <%--<asp:Button ID="btnEliminar" CssClass="btn btn-primary" Text="Eliminar" CommandArgument='<%#Eval("Id")%>' CommandName="idPokemon" runat="server" OnClick="btnEliminar_Click" />--%>
                        <asp:Button Text="Eliminar" CssClass="btn btn-primary" ID="btnEliminar2" OnClick="btnEliminar2_Click" CommandArgument='<%#Eval("Id")%>' runat="server" />
                    </td>
                </tr>

            </ItemTemplate>
        </asp:Repeater>
        <tr>
            <td><b>Total</b></td>
           <td><b><%= total.ToString("C",new System.Globalization.CultureInfo("en-US")) %> </b> </td>
           
        </tr>
    </table>

    <%--<table class ="table">
        
                
    </table>--%>



    <asp:Label ID="lblEjemplo" runat="server" />
    <asp:Label ID="lblDesplegable" runat="server" />








<%--    <asp:Label Id="lblSeleccionado" runat="server"/>
    <asp:Label Id="lblUrlImagen" runat="server"/>--%>


</asp:Content>
