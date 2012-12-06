<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PaqueteTuristicoWeb.TourWS.Paquete>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Portal Turístico S.O.S.
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detalles</h2>

    <fieldset>
        <legend>Campos</legend>
        
        <div class="display-label">Codigo</div>
        <div class="display-field"><%: Model.CodPaquete %></div>
        
        <div class="display-label">Tipo de Paquete</div>
        <div class="display-field"><%: Model.TipoPaquete.CodTipoPaquete %> - <%: Model.TipoPaquete.NombreTipoPaquete %></div>

        <div class="display-label">Nombre</div>
        <div class="display-field"><%: Model.NombrePaquete %></div>
        
        <div class="display-label">FechaInicio</div>
        <div class="display-field"><%: Model.FechaInicio %></div>
        
        <div class="display-label">Fecha de Fin</div>
        <div class="display-field"><%: Model.FechaFin %></div>
        
        <div class="display-label">Hora de Inicio</div>
        <div class="display-field"><%: Model.HoraInicio %></div>
        
        <div class="display-label">Hora de Fin</div>
        <div class="display-field"><%: Model.HoraFin %></div>
        
        <div class="display-label">Descripcion</div>
        <div class="display-field"><%: Model.Descripcion %></div>
        
        <div class="display-label">Lugares</div>
        <div class="display-field"><%: Model.Lugares %></div>
        
        <div class="display-label">Informacion Adicional</div>
        <div class="display-field"><%: Model.InformacionAdicional %></div>

        <div class="display-label">Precio</div>
        <div class="display-field"><%: Model.Precio %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "Edit", new { id=Model.CodPaquete}) %> |
        <%: Html.ActionLink("Regresar a la lista", "Index")%>
    </p>

</asp:Content>

