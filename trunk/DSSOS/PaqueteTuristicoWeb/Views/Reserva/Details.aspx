<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PaqueteTuristicoWeb.TourWS.Reserva>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Portal Turístico S.O.S.
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2><strong>Detalles</strong></h2>

    <fieldset>
        <legend>Campos</legend>
        
        <div class="display-label">Código de la Reserva</div>
        <div class="display-field"><%: Model.CodReserva %></div>
        
        <div class="display-label">Código del Paquete</div>
        <div class="display-field"><%: Model.Paquete.CodPaquete %></div>

        <div class="display-label">Nombre del Paquete</div>
        <div class="display-field"><%: Model.Paquete.Descripcion %></div>
        
        <div class="display-label">Código del Cliente</div>
        <div class="display-field"><%: Model.Cliente.CodCliente %></div>
        
         <div class="display-label">Nombre del Cliente</div>
        <div class="display-field"><%: Model.Cliente.NombreCliente%> <%: Model.Cliente.ApellidoCliente%></div>
        
        <div class="display-label">Estado</div>
        <div class="display-field"><%: Model.Estado %></div>
        
        <div class="display-label">FechaReserva</div>
        <div class="display-field"><%: String.Format("{0:g}", Model.FechaReserva) %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "Edit", new { id=Model.CodReserva }) %> |
        <%: Html.ActionLink("Regresar al listado", "Index") %>
    </p>

</asp:Content>

