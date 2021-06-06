<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="AplicacionaWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h2>Carrito de Compras</h2>
    
    <asp:Label Text="Colores" runat="server" />
    <asp:DropDownList runat="server">
        <asp:ListItem Text="Rojo" />
        <asp:ListItem Text="Azul" />
    </asp:DropDownList>
    <table class="table">
        <tr>
            <td>Nombre</td>
            <td>Precio</td>
            <td>Acción</td>
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
    </table>
    <table class ="table">
        <tr>
            <td>Total</td>
            <th><% %></th>
        </tr>
                
    </table>



    <asp:Label ID="lblEjemplo" runat="server" />
    <asp:Label ID="lblDesplegable" runat="server" />








<%--    <asp:Label Id="lblSeleccionado" runat="server"/>
    <asp:Label Id="lblUrlImagen" runat="server"/>--%>


</asp:Content>
