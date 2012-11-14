<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<PaqueteTuristicoWeb.Models.Reserva>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Reservas</h2>

    <table>
        <tr>
            <th></th>
            <th>
                CodReserva
            </th>
            <th>
                Paquete
            </th>
            <th>
                Cliente
            </th>
            <th>
                Estado
            </th>
            <th>
                FechaReserva
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id=item.CodReserva}) %> |
                <%: Html.ActionLink("Detalles", "Details", new { id = item.CodReserva })%> |
                <%: Html.ActionLink("Eliminar", "Delete", new { id = item.CodReserva })%>
            </td>
            <td>
                <%: item.CodReserva %>
            </td>
            <td>
                <%: item.Paquete.CodPaquete %>
            </td>
            <td>
                <%: item.Cliente.CodCliente %>
            </td>
            <td>
                <%: item.Estado %>
            </td>
            <td>
                <%: item.FechaReserva %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear", "Create") %>
    </p>

</asp:Content>

