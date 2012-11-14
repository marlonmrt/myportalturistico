<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PaqueteTuristicoWeb.Models.Reserva>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	PortalTuristico
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edición</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Campos</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.CodReserva) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.CodReserva) %>
                <%: Html.ValidationMessageFor(model => model.CodReserva) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Estado) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Estado) %>
                <%: Html.ValidationMessageFor(model => model.Estado) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.FechaReserva) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.FechaReserva) %>
                <%: Html.ValidationMessageFor(model => model.FechaReserva) %>
            </div>
            
            <p>
                <input type="submit" value="Guardar" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar a la Lista", "Index") %>
    </div>

</asp:Content>

