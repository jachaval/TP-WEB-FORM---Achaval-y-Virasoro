<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="AplicacionaWeb.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Contacto</h2>
    <h3>Pongase en Contacto con nosotros.</h3>

    <div id="after_submit"></div>
    <form id="contact_form" action="#" method="POST" enctype="multipart/form-data">
        <div class="row">
            <label class="required" for="name">Ingrese su nombre:</label><br />
            <input id="name" class="input" name="name" type="text" value="" size="30" /><br />
            <span id="name_validation" class="error_message"></span>
        </div>
        <div class="row">
            <label class="required" for="email">Ingrese su email:</label><br />
            <input id="email" class="input" name="email" type="text" value="" size="30" /><br />
            <span id="email_validation" class="error_message"></span>
        </div>
        <div class="row">
            <label class="required" for="message">Ingrese su mensaje:</label><br />
            <textarea id="message" class="input" name="message" rows="7" cols="30"></textarea><br />
            <span id="message_validation" class="error_message"></span>
        </div>

        <input id="submit_button" type="submit" value="Enviar email" />
    </form>

    <br />
    <br />
    <div class="pieContacto">
        <div>
            <address>
                <b>Dirección:</b><br />
                Capital Federal<br />
                Corrientes 425<br />
                <abbr title="Phone">Tel:</abbr>
                0800-444-TECH
            </address>

            <address>
                <strong>Support:</strong>   <a href="mailto:Ale_virasoro@support.com">Ale_virasoro@support.com</a><br />
                <strong>Marketing:</strong> <a href="mailto:joa_achaval@hotmail.com">Joa_achaval@marketing.com</a>
            </address>
        </div>
        <div>
            <b>Nuestras Redes:</b><br />       
            <a href="https://github.com/jachaval/TP-WEB-FORM---Achaval-y-Virasoro" target="_blank">GITHUB</i></a><br />
            <a href="https://WWW.TECHNOLOGICSTORE.COM" target="_blank">WWW.TECHNOLOGICSTORE.COM</a>
        </div>
    </div>
</asp:Content>
