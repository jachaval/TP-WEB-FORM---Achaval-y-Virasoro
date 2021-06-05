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
            <td>Acción</td>
            <td>Cantidad</td>
        </tr>

        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Nombre")%></td>
                    <td>
                        <%--<asp:Button ID="btnEliminar" CssClass="btn btn-primary" Text="Eliminar" CommandArgument='<%#Eval("Id")%>' CommandName="idPokemon" runat="server" OnClick="btnEliminar_Click" />--%>
                        <asp:Button Text="Eliminar" CssClass="btn btn-primary" ID="btnEliminar2" OnClick="btnEliminar2_Click" CommandArgument='<%#Eval("Id")%>' runat="server" />
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtCantidad" runat="server" AutoPostBack="true" OnTextChanged="txtCantidad_TextChanged" />
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlCantidad" AutoPostBack="true" CommandArgument='<%#Eval("Id")%>' OnSelectedIndexChanged="ddlCantidad_SelectedIndexChanged">
                            <asp:ListItem Text="1" />
                            <asp:ListItem Text="2" />
                            <asp:ListItem Text="3" />
                        </asp:DropDownList>
                    </td>
                </tr>

            </ItemTemplate>
        </asp:Repeater>


    </table>

    <asp:Label ID="lblEjemplo" runat="server" />
    <asp:Label ID="lblDesplegable" runat="server" />








<%--    <asp:Label Id="lblSeleccionado" runat="server"/>
    <asp:Label Id="lblUrlImagen" runat="server"/>--%>


</asp:Content>
