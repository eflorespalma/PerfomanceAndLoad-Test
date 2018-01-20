<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListPersons.aspx.cs" Inherits="Course.Web.Persons.ListPersons" %>

<%@ Register Src="~/Shared/MenuControl.ascx" TagPrefix="uc1" TagName="MenuControl" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Listado de Personas</title>
    <style type="text/css">
        table {
            border-collapse: collapse;
            width: 80%;
            font: 13px Arial, Helvetica, sans-serif;
        }

        th, td {
            text-align: left;
            padding: 8px;
        }

        tr:nth-child(even) {
            background-color: #f2f2f2
        }

        th {
            background-color: #FF8500;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:MenuControl runat="server" ID="MenuControl" />
            &nbsp;<br />
            <h3>Listado de Personas</h3>
            <asp:GridView ID="m_grid" runat="server" AutoGenerateColumns="False"
                BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" EmptyDataText="No person records found." OnRowDataBound="m_grid_RowDataBound">
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="EditPersons.aspx?Id={0}"
                        Text="Editar" />
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="LastName" HeaderText="Apellidos" />
                    <asp:BoundField DataField="FirstName" HeaderText="Nombres" />
                    <asp:BoundField DataField="PhoneNumber" HeaderText="Celular" />
                    <asp:BoundField DataField="EmailAddress" HeaderText="Email" />
                    <asp:BoundField DataField="Genere" HeaderText="Genero" />
                </Columns>
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="Gainsboro" />
            </asp:GridView>
            <p style="font-weight: bold;">
                Total Registros: 
            <asp:Label ID="lblRowCount" runat="server" Style="font-weight: bold;" Text=""></asp:Label>

            </p>
        </div>
    </form>
</body>
</html>
