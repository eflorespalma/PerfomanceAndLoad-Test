﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPersons.aspx.cs" Inherits="Course.Web.Persons.EditPerson" %>

<%@ Register Src="~/Shared/MenuControl.ascx" TagPrefix="uc1" TagName="MenuControl" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mantenimiento de Personas</title>
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:MenuControl ID="MainMenuControl1" runat="server" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

            <div class="form-style-2">
                <div class="form-style-2-heading">Mantenimiento de Personas</div>
                <div>
                    <span style="font-weight: bold;">Id</span>
                    <asp:Label ID="lblId" runat="server" Style="padding-left: 100px; font-weight: bold;" Text="">
                    </asp:Label>
                </div>
                <br />
                <label for="field2">
                    <span>Nombres</span>
                    <asp:TextBox ID="txtFirstName" runat="server" CssClass="input-field"></asp:TextBox>
                </label>
                <label for="field3">
                    <span>Apellidos</span>
                    <asp:TextBox ID="txtLastName" runat="server" CssClass="input-field"></asp:TextBox>
                </label>
                <label for="field4">
                    <span>Celular</span>
                    <asp:TextBox ID="txtPhone" runat="server" CssClass="input-field"></asp:TextBox>
                </label>
                <label for="field5">
                    <span>Email</span>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="input-field"></asp:TextBox>
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