<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PaqueteTuristicoWeb.Models.Reserva>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	PortalTuristico
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detalles</h2>

    <fieldset>
        <legend>Campos</legend>
        
        <div class="display-label">CodReserva</div>
        <div class="display-field"><%: Model.CodReserva %></div>

        <div class="display-label">Paquete</div>
        <div class="display-field"><%: Model.Paquete.CodPaquete %></div>

        <div class="display-label">Cliente</div>
        <div class="display-field"><%: Model.Cliente.CodCliente %></div>
        
        <div class="display-label">Estado</div>
        <div class="display-field"><%: Model.Estado %></div>
        
        <div class="display-label">FechaReserva</div>
        <div class="display-field"><%: Model.FechaReserva %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "Edit", new { id=Model.CodReserva }) %> |
        <%: Html.ActionLink("Regresar a la Lista", "Index") %>
    </p>

</asp:Content>

