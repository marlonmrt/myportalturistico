<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PaqueteTuristicoWeb.TourWS.Paquete>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	S.O.S.
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Eliminación</h2>

    <h3>¿Seguro de que desea eliminar este paquete?</h3>
    <fieldset>
        <legend>Campos</legend>
        
        <div class="display-label">Codigo</div>
        <div class="display-field"><%: Model.Codigo %></div>
        
        <div class="display-label">Nombre</div>
        <div class="display-field"><%: Model.Nombre %></div>
        
        <div class="display-label">FechaInicio</div>
        <div class="display-field"><%: Model.FechaInicio %></div>
        
        <div class="display-label">FechaFin</div>
        <div class="display-field"><%: Model.FechaFin %></div>
        
        <div class="display-label">HoraInicio</div>
        <div class="display-field"><%: Model.HoraInicio %></div>
        
        <div class="display-label">HoraFin</div>
        <div class="display-field"><%: Model.HoraFin %></div>
        
        <div class="display-label">Descripcion</div>
        <div class="display-field"><%: Model.Descripcion %></div>
        
        <div class="display-label">Lugares</div>
        <div class="display-field"><%: Model.Lugares %></div>
        
        <div class="display-label">InformacionAdicional</div>
        <div class="display-field"><%: Model.InformacionAdicional %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Eliminar Paquete" /> |
		    <%: Html.ActionLink("Regresar a la lista", "Index") %>
        </p>
    <% } %>

</asp:Content>

