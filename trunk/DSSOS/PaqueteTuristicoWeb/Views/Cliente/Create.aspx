<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PaqueteTuristicoWeb.Models.Cliente>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Portal Turístico S.O.S.
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2><strong>Registrar Cliente</strong></h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Campos</legend>
            
            <!--
            <div class="editor-label">
                <%: Html.LabelFor(model => model.CodCliente) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.CodCliente ) %>
                <%: Html.ValidationMessageFor(model => model.CodCliente) %>
            </div>
            -->
            <div class="editor-label">
                Nombre
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.NombreCliente, new { @style = "width:300px" })%>
                <%: Html.ValidationMessageFor(model => model.NombreCliente) %>
            </div>
            
            <div class="editor-label">
                Apellido
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.ApellidoCliente, new { @style = "width:300px" })%>
                <%: Html.ValidationMessageFor(model => model.ApellidoCliente) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.DNI) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.DNI, new { @style = "width:200px" })%>
                <%: Html.ValidationMessageFor(model => model.DNI) %>
            </div>
            
            <div class="editor-label">
                Correo
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.CorreoCliente, new { @style = "width:300px" })%>
                <%: Html.ValidationMessageFor(model => model.CorreoCliente) %>
            </div>
            
            <p>
                <input type="submit" value="Registrar Cliente" />
            </p>
            
            <!-- esto es donde se ve el mensaje  -->
            <p style="color:Red; font-weight:bold"><%= ViewData["mensaje"] %></p>
        </fieldset>

    <% } %>

   <!--
    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>
    -->
</asp:Content>

