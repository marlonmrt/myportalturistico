<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PaqueteTuristicoWeb.Models.Paquete>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	S.O.S.
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edición</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Campos</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Codigo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Codigo) %>
                <%: Html.ValidationMessageFor(model => model.Codigo) %>
            </div>
             <div class="editor-label">
               Tipo de Paquete
            </div>
            <div class="editor-field">
                <%: Html.DropDownList("tiposPaquete", ViewData["tiposPaquete"] as SelectList)%>
            </div>
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Nombre) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Nombre) %>
                <%: Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.FechaInicio) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.FechaInicio) %>
                <%: Html.ValidationMessageFor(model => model.FechaInicio) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.FechaFin) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.FechaFin) %>
                <%: Html.ValidationMessageFor(model => model.FechaFin) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.HoraInicio) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.HoraInicio) %>
                <%: Html.ValidationMessageFor(model => model.HoraInicio) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.HoraFin) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.HoraFin) %>
                <%: Html.ValidationMessageFor(model => model.HoraFin) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Descripcion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Descripcion) %>
                <%: Html.ValidationMessageFor(model => model.Descripcion) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Lugares) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Lugares) %>
                <%: Html.ValidationMessageFor(model => model.Lugares) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.InformacionAdicional) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.InformacionAdicional) %>
                <%: Html.ValidationMessageFor(model => model.InformacionAdicional) %>
            </div>
            
            <p>
                <input type="submit" value="Grabar Paquete" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar a la Lista", "Index") %>
    </div>

</asp:Content>

