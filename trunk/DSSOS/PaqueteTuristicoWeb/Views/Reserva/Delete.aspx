<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PaqueteTuristicoWeb.Models.Reserva>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	PortalTuristico
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Eliminación</h2>

    <h3>¿Seguro(a) de eliminar esta reserva?</h3>
    <fieldset>
        <legend>Campos</legend>
        
        <div class="display-label">CodReserva</div>
        <div class="display-field"><%: Model.CodReserva %></div>
        
        <div class="display-label">Estado</div>
        <div class="display-field"><%: Model.Estado %></div>
        
        <div class="display-label">FechaReserva</div>
        <div class="display-field"><%: Model.FechaReserva %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Eliminar" /> |
		    <%: Html.ActionLink("Regresar a la lista", "Index") %>
        </p>
    <% } %>

</asp:Content>

