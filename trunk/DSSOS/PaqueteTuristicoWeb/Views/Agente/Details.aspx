<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PaqueteTuristicoWeb.Models.Agente>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Portal Turístico S.O.S.
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detalle de Agente</h2>

    <fieldset>
        <legend>Datos</legend>
        
        <div class="display-label">RazonSocial</div>
        <div class="display-field"><%: Model.RazonSocial %></div>
        
        <div class="display-label">RUC</div>
        <div class="display-field"><%: Model.RUC %></div>
        
        <div class="display-label">Direccion</div>
        <div class="display-field"><%: Model.Direccion%></div>

        <div class="display-label">CorreoAgente</div>
        <div class="display-field"><%: Model.CorreoAgente%></div>
        
        <div class="display-label">Cuenta Interbancaria</div>
        <div class="display-field"><%: Model.NroCuentaInterbancaria%></div>

    </fieldset>
    <p>
       <%: Html.ActionLink("Retornar", "Index") %>
    </p>

</asp:Content>
