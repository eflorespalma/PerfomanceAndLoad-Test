<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListProduct.aspx.cs" Inherits="Course.Web.Products.ListProduct" %>

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

            <div>
                <div>
                    <h3>Listado de Productos
                    </h3>
                </div>
                <div style="padding-bottom: 10px;">
                    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" Style="border: none; padding: 8px 15px 8px 15px; background: #FF8500; color: #fff; box-shadow: 1px 1px 4px #DADADA; -moz-box-shadow: 1px 1px 4px #DADADA; -webkit-box-shadow: 1px 1px 4px #DADADA; border-radius: 3px; -webkit-border-radius: 3px; -moz-border-radius: 3px;" />
                </div>
            </div>
            <asp:GridView ID="grvProduct" runat="server" AutoGenerateColumns="False"
                BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" EmptyDataText="No products records found." OnRowDataBound="grvProduct_RowDataBound">
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="EditProduct.aspx?Id={0}"
                        Text="Editar" />
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Nombre" />
                    <asp:BoundField DataField="Category" HeaderText="Categoría" />
                    <asp:BoundField DataField="Price" HeaderText="Precio" />
                    <asp:BoundField DataField="Stock" HeaderText="Stock" />
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
