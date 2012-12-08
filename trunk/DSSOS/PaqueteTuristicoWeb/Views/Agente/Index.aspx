<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<PaqueteTuristicoWeb.Models.Agente>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Portal Turístico S.O.S.
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Mantenimiento de Agentes</h2>

    <table>
        <tr>
            <th></th>
            <th>
                RazonSocial
            </th>
            <th>
                RUC
            </th>
            <th>
                Dirección
            </th>

        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id = item.RUC })%> |  
                <%: Html.ActionLink("Detalle", "Details", new { id = item.RUC})%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.RUC })%>
            </td>
            <td>
                <%: item.RazonSocial%>
            </td>
            <td>
                <%: item.RUC%>
            </td>
            <td>
                <%: item.Direccion%>
            </td>

        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Nuevo Agente", "Create") %>
    </p>

</asp:Content>

