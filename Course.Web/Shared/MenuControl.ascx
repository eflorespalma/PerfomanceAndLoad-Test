<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuControl.ascx.cs" Inherits="Course.Web.Shared.MenuControl" %>
<style>
    ul {
        list-style-type: none;
        margin: 0;
        padding: 0;
        overflow: hidden;
        background-color: #333;
    }

    li {
        float: left;
    }

        li a {
            display: block;
            color: white;
            text-align: center;
            padding: 14px 16px;
            text-decoration: none;
        }

            li a:hover {
                background-color: #111;
            }
</style>
<ul>
    <li>
        <asp:HyperLink CssClass="active" ID="HyperLink1" NavigateUrl="~/Persons/ListPersons.aspx" runat="server">Listado Principal</asp:HyperLink></li>
    <li>
        <asp:HyperLink ID="m_linkNewPerson" runat="server" NavigateUrl="~/Persons/EditPersons.aspx?Id=-1">Registrar Persona</asp:HyperLink></li>
</ul>
