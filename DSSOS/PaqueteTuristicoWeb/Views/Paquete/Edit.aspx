﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PaqueteTuristicoWeb.TourWS.Paquete>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Portal Turístico S.O.S.
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edición</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>

            <legend>Campos</legend>
            
            <div class="editor-label">
                Código del paquete
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.CodPaquete, new { @readonly = true })%>  
                <%: Html.ValidationMessageFor(model => model.CodPaquete)%>
            </div>
             <div class="editor-label">
               Tipo de Paquete
            </div>
            <div class="editor-field">
                <%: Html.DropDownList("tiposPaquete", ViewData["tiposPaquete"] as SelectList)%>
            </div>
         <div class="editor-label">
                Nombre del Paquete
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.NombrePaquete, new { @style = "width:300px" })%>
                <%: Html.ValidationMessageFor(model => model.NombrePaquete)%>
            </div>
            
            <div class="editor-label">
                Fecha de Inicio
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.FechaInicio, new { @class = "datepicker", Value = String.Format("{0:dd/MM/yyyy}", Model.FechaInicio), @style = "width:100px" })%>
                <%: Html.ValidationMessageFor(model => model.FechaInicio) %>
            </div>
            
            <div class="editor-label">
                Fecha de Fin
            </div>
            <div class="editor-field">
                
                <%: Html.TextBoxFor(model => model.FechaFin, new { @class = "datepicker", Value = String.Format("{0:dd/MM/yyyy}", Model.FechaFin), @style = "width:100px" })%>
                <%: Html.ValidationMessageFor(model => model.FechaFin) %>
            </div>
            
            <div class="editor-label">
                Hora de Inicio
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.HoraInicio, new { @style = "width:100px" })%>
                <%: Html.ValidationMessageFor(model => model.HoraInicio) %>
            </div>
            
            <div class="editor-label">
                Hora de Fin
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.HoraFin, new { @style = "width:100px" })%>
                <%: Html.ValidationMessageFor(model => model.HoraFin) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Descripcion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextAreaFor(model => model.Descripcion, new { @style = "width:300px;height:80px" })%>
                <%: Html.ValidationMessageFor(model => model.Descripcion) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Lugares) %>
            </div>
            <div class="editor-field">
                <%: Html.TextAreaFor(model => model.Lugares, new { @style = "width:300px;height:80px" })%>
                <%: Html.ValidationMessageFor(model => model.Lugares) %>
            </div>
            
            <div class="editor-label">
                Información Adicional
            </div>
            <div class="editor-field">
                <%: Html.TextAreaFor(model => model.InformacionAdicional, new { @style = "width:300px;height:80px" })%>
                <%: Html.ValidationMessageFor(model => model.InformacionAdicional) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Precio) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Precio, new { @style = "width:100px" })%>
                <%: Html.ValidationMessageFor(model => model.Precio)%>
            </div>

             <div class="editor-label">
                <%: Html.LabelFor(model => model.Cupos) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Cupos, new { @style = "width:100px" })%>
                <%: Html.ValidationMessageFor(model => model.Cupos)%>
            </div>

             <div class="editor-label">
                <%: Html.LabelFor(model => model.Registrados) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Registrados, new { @style = "width:100px" })%>
                <%: Html.ValidationMessageFor(model => model.Registrados)%>
            </div>
            <div class="editor-label">
              Agente
            </div>
            <div class="editor-field">
                <%: Html.DropDownList("agentes", ViewData["agentes"] as SelectList)%>
            </div>
            <p>
                <input type="submit" value="Grabar Paquete" />
            </p>
             <!-- esto es donde se ve el mensaje  -->
            <p style="color:Red; font-weight:bold"><%= ViewData["mensaje"] %></p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar a la Lista", "Index") %>
    </div>

</asp:Content>

