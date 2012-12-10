<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PaqueteTuristicoWeb.TourWS.Reserva>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Portal Turístico S.O.S.
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Creación</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary("Ocurrió un error") %>

        <fieldset>
            <legend>Campos</legend>
           
            <div class="editor-label">
                Paquete Turístico
            </div>
           <div class="editor-field">
                <%: Html.DropDownList("paquetes", ViewData["paquetes"] as SelectList)%>
            </div>

            <div class="editor-label">
                Cliente
            </div>
            <div class="editor-field">
                <%: Html.DropDownList("clientes", ViewData["cliente"] as SelectList)%>
            </div>
            
          <p style="color:Green; font-weight:bold">El estado con que se realiza la Reserva es "R" de "Reservado"</p>
          
          <p style="color:Green; font-weight:bold">La fecha es la del día"</p>  
            
            <p>
                <input type="submit" value="Crear" />
            </p>
             <!-- esto es donde se ve el mensaje  -->
            <p style="color:Red; font-weight:bold"><%= ViewData["mensaje"] %></p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar a la Lista", "Index") %>
    </div>

</asp:Content>
