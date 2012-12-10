<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PaqueteTuristicoWeb.TourWS.Reserva>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

     <h2>Creación</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary("Ocurrió un error")%>

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
                <%: Html.DropDownList("clientes", ViewData["clientes"] as SelectList)%>
            </div>
           
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Estado) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Estado) %>
                <%: Html.ValidationMessageFor(model => model.Estado) %>
            </div>
            
            <div class="editor-label">
               Fecha de la Reserva
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.FechaReserva, new { @class = "datepicker", Value = String.Format("{0:dd/MM/yyyy}", Model.FechaReserva), @style = "width:100px" })%>
                <%: Html.ValidationMessageFor(model => model.FechaReserva) %>
            </div>
            
            <p>
                <input type="submit" value="Editar" />
            </p>
             <!-- esto es donde se ve el mensaje  -->
            <p style="color:Red; font-weight:bold"><%= ViewData["mensaje"] %></p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar a la Lista", "Index") %>
    </div>

</asp:Content>
