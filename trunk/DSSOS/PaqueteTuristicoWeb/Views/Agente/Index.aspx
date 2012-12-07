<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PaqueteTuristicoWeb.Models.Agente>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Portal Turístico S.O.S.
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2><strong>Registrar Agente</strong></h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Campos</legend>
            
            <!--
            <div class="editor-label">
                <%: Html.LabelFor(model => model) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.CodAgente) %>
                <%: Html.ValidationMessageFor(model => model.CodAgente) %>
            </div>
            -->
            <div class="editor-label">
                RazonSocial
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.RazonSocial, new { @style = "width:300px" })%>
                <%: Html.ValidationMessageFor(model => model.RazonSocial)%>
            </div>
                      
            <div class="editor-label">
                <%: Html.LabelFor(model => model.RUC) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.RUC, new { @style = "width:200px" })%>
                <%: Html.ValidationMessageFor(model => model.RUC)%>
            </div>
            
            <div class="editor-label">
                Correo
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.CorreoAgente, new { @style = "width:300px" })%>
                <%: Html.ValidationMessageFor(model => model.CorreoAgente)%>
            </div>

            <div class="editor-label">
                Dirección
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Direccion, new { @style = "width:300px" })%>
                <%: Html.ValidationMessageFor(model => model.Direccion)%>
            </div>

            <div class="editor-label">
                Cta. Interbancaria
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.NroCuentaInterbancaria, new { @style = "width:300px" })%>
                <%: Html.ValidationMessageFor(model => model.NroCuentaInterbancaria)%>
            </div>
            
            <p>
                <input type="submit" value="Registrar Agente" />
            </p>
              <p style="color:Red; font-weight:bold"><%= ViewData["mensaje"] %></p>
        </fieldset>

    <% } %>

   <!--
    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>
    -->
</asp:Content>

