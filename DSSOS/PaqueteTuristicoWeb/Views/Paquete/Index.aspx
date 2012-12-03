<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<PaqueteTuristicoWeb.TourWS.Paquete>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Portal Turístico S.O.S.
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2><strong>Listado de Paquetes</strong></h2>
    <br />
    <table cellpadding="2" cellspacing="2" border="0", style="width:450px">
    <% foreach (var item in Model) { %>

    <tr>
       <td style="width: 144px"><strong>Código de Paquete</strong></td><td><%: item.CodPaquete %></td><td><strong>Tipo de Excursión</strong></td><td><%: item.TipoPaquete.CodTipoPaquete %> - <%: item.TipoPaquete.NombreTipoPaquete %></td>
    </tr>
     <tr>
       <td style="width: 144px"><strong>Nombre del Paquete</strong></td><td colspan="3"><%: item.NombrePaquete %></td>
    </tr>  
    <tr>
       <td style="width: 144px"><strong>Fecha de Inicio</strong></td><td> <%: item.FechaInicio %></td><td><strong>Fecha de Fin</strong></td><td> <%: item.FechaFin %></td>
    </tr>
    <tr>
       <td style="width: 144px"><strong>Hora de Inicio</strong></td><td><%: item.HoraInicio %></td><td><strong>Hora de Fin</strong></td><td><%: item.HoraFin %></td>
    </tr>
    <tr>
       <td style="width: 144px"><strong>Descripcion</strong></td><td colspan="3"><%: item.Descripcion %></td>
    </tr>
     <tr>
       <td style="width: 144px"><strong>Lugares</strong></td><td colspan="3"><%: item.Lugares %></td>
    </tr>
    <tr>
    <td style="width: 144px"><strong>Información Adicional</strong></td><td colspan="3"><%: item.InformacionAdicional %></td>
    </tr>

     <tr>
       <td style="width: 144px"><strong>Precio</strong></td><td ><%: item.Precio %></td><td><strong>Cupos Disponibles</strong></td><td> <%: item.Cupos - item.Registrados %></td>
    </tr>
     <tr>
       <td style="width: 144px"><strong>Agente</strong></td><td colspan="3"><%: item.Agente.RazonSocial %></td>
    </tr>
    <tr>
       <td colspan="4"> <%: Html.ActionLink("Editar", "Edit", new { id=item.CodPaquete }) %> |
                <%: Html.ActionLink("Detalles", "Details", new { id = item.CodPaquete })%> |
                <%: Html.ActionLink("Eliminar", "Delete", new { id = item.CodPaquete })%></td>
    </tr>
    <tr>
       <td colspan="4"><hr /></td>
    </tr>
    <% } %>
    </table>

    <p>
        <%: Html.ActionLink("Crear Nuevo Paquete", "Create") %>
    </p>

</asp:Content>

