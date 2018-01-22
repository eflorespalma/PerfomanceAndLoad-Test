<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="Course.Web.Products.EditProduct" %>

<%@ Register Src="~/Shared/MenuControl.ascx" TagPrefix="uc1" TagName="MenuControl" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mantenimiento de Productos</title>
    <style type="text/css">
        .form-style-2 {
            max-width: 500px;
            padding: 20px 12px 10px 20px;
            font: 13px Arial, Helvetica, sans-serif;
        }

        .form-style-2-heading {
            font-weight: bold;
            font-style: italic;
            border-bottom: 2px solid #ddd;
            margin-bottom: 20px;
            font-size: 15px;
            padding-bottom: 3px;
        }

        .form-style-2 label {
            display: block;
            margin: 0px 0px 15px 0px;
        }

            .form-style-2 label > span {
                width: 100px;
                font-weight: bold;
                float: left;
                padding-top: 8px;
                padding-right: 5px;
            }

        .form-style-2 input.input-field {
            width: 48%;
        }

        .form-style-2 select.input-field {
            width: 48%;
        }

        .form-style-2 input.input-field {
            box-sizing: border-box;
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            border: 1px solid #C2C2C2;
            box-shadow: 1px 1px 4px #EBEBEB;
            -moz-box-shadow: 1px 1px 4px #EBEBEB;
            -webkit-box-shadow: 1px 1px 4px #EBEBEB;
            border-radius: 3px;
            -webkit-border-radius: 3px;
            -moz-border-radius: 3px;
            padding: 7px;
            outline: none;
        }

        .form-style-2 select.input-field {
            box-sizing: border-box;
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            border: 1px solid #C2C2C2;
            box-shadow: 1px 1px 4px #EBEBEB;
            -moz-box-shadow: 1px 1px 4px #EBEBEB;
            -webkit-box-shadow: 1px 1px 4px #EBEBEB;
            border-radius: 3px;
            -webkit-border-radius: 3px;
            -moz-border-radius: 3px;
            padding: 7px;
            outline: none;
        }

        .form-style-2 .input-field:focus {
            border: 1px solid #0C0;
        }

        .form-style-2 input[type=submit],
        .form-style-2 input[type=button] {
            border: none;
            padding: 8px 15px 8px 15px;
            background: #FF8500;
            color: #fff;
            box-shadow: 1px 1px 4px #DADADA;
            -moz-box-shadow: 1px 1px 4px #DADADA;
            -webkit-box-shadow: 1px 1px 4px #DADADA;
            border-radius: 3px;
            -webkit-border-radius: 3px;
            -moz-border-radius: 3px;
        }

            .form-style-2 input[type=submit]:hover,
            .form-style-2 input[type=button]:hover {
                background: #EA7B00;
                color: #fff;
            }

        .valFailure {
            color: #bf1616;
            background: #FFBABA !important;
            background-color: #FFBABA;
            border: 3px solid #bf1616;
            font-weight: bold;
            text-align: left;
            margin: 5px 0;
            line-height: 1;
        }

            .valFailure ul {
                padding-left: 20px;
            }

                .valFailure ul li {
                    padding-top: 2px;
                }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:MenuControl ID="MainMenuControl1" runat="server" />
            <div class="form-style-2">
                <asp:ValidationSummary ID="ValidationSummary1" CssClass="valFailure" runat="server" />
                <div class="form-style-2-heading">Mantenimiento de Productos</div>
                <div>
                    <span style="font-weight: bold;">Id</span>
                    <asp:Label ID="lblId" runat="server" Style="padding-left: 100px; font-weight: bold;" Text="">
                    </asp:Label>
                </div>
                <br />
                <label for="field2">
                    <span>Nombre</span>
                    <asp:TextBox ID="txtName" runat="server" CssClass="input-field"></asp:TextBox>
                </label>
                <label for="field3">
                    <span>Categoría</span>
                    <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="input-field">
                        <asp:ListItem Value="">-- Seleccionar --</asp:ListItem>
                        <asp:ListItem Value="P">Portátiles</asp:ListItem>
                        <asp:ListItem Value="I">Impresión</asp:ListItem>
                        <asp:ListItem Value="A">Almacenamiento</asp:ListItem>
                        <asp:ListItem Value="S">Software</asp:ListItem>
                        <asp:ListItem Value="T">Tablets</asp:ListItem>
                    </asp:DropDownList>
                </label>
                <label for="field4">
                    <span>Precio $</span>
                    <asp:TextBox ID="txtPrecio" runat="server" CssClass="input-field"></asp:TextBox>
                </label>
                <label for="field5">
                    <span>Stock</span>
                    <asp:TextBox ID="txtStock" runat="server" CssClass="input-field"></asp:TextBox>
                </label>
                <label>
                    <span>&nbsp;</span>
                    <asp:Button ID="btnSave" runat="server" Text="Guardar" OnClick="btnSave_Click" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancelar" OnClick="btnCancel_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Eliminar" OnClick="btnDelete_Click" />
                </label>
            </div>
        </div>
    </form>
</body>
</html>

