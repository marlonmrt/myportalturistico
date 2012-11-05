<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<PaqueteTuristicoWeb.Models.Paquete>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	S.O.S.
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Listado de Paquetes</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Codigo
            </th>
             <th>
                Tipo de Excursión
            </th>
            <th>
                Nombre
            </th>
            <th>
                FechaInicio
            </th>
            <th>
                FechaFin
            </th>
            <th>
                HoraInicio
            </th>
            <th>
                HoraFin
            </th>
            <th>
                Descripcion
            </th>
            <th>
                Lugares
            </th>
            <th>
                InformacionAdicional
            </th>
            <th>
                Precio
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id=item.Codigo }) %> |
                <%: Html.ActionLink("Detalles", "Details", new { id = item.Codigo })%> |
                <%: Html.ActionLink("Eliminar", "Delete", new { id = item.Codigo })%>
            </td>
            <td>
                <%: item.Codigo %>
            </td>

            <td>
                <%: item.TipoPaquete.Codigo %> - <%: item.TipoPaquete.Nombre %>
            </td>

            <td>
                <%: item.Nombre %>
            </td>
            <td>
                <%: item.FechaInicio %>
            </td>
            <td>
                <%: item.FechaFin %>
            </td>
            <td>
                <%: item.HoraInicio %>
            </td>
            <td>
                <%: item.HoraFin %>
            </td>
            <td>
                <%: item.Descripcion %>
            </td>
            <td>
                <%: item.Lugares %>
            </td>
            <td>
                <%: item.InformacionAdicional %>
            </td>
             <td>
                <%: item.Precio %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear Nuevo Paquete", "Create") %>
    </p>

</asp:Content>

