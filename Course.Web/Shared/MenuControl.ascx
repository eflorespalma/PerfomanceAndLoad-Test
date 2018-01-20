<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuControl.ascx.cs" Inherits="Course.Web.Shared.MenuControl" %>
<style>
    .lit a:hover {
        background-color: #111;
    }
</style>
<ul style="list-style-type: none; margin: 0; padding: 0; overflow: hidden; background-color: #333;">
    <li class="lit" style="float: left">
        <asp:HyperLink CssClass="active" Style="display: block; color: white; text-align: center; padding: 14px 16px; text-decoration: none;" ID="HyperLink1" NavigateUrl="~/Persons/ListPersons.aspx" runat="server">Listado Principal</asp:HyperLink></li>
    <li class="lit" style="float: left">
        <asp:HyperLink ID="m_linkNewPerson" Style="display: block; color: white; text-align: center; padding: 14px 16px; text-decoration: none;" runat="server" NavigateUrl="~/Persons/EditPersons.aspx?Id=-1">Registrar Persona</asp:HyperLink></li>
    <%--<li class="lit" style="float: left">
        <asp:HyperLink ID="HyperLink2" Style="display: block; color: white; text-align: center; padding: 14px 16px; text-decoration: none;" runat="server" NavigateUrl="~/Gifts/RegisterGift.aspx?Id=-1">Registrar Regalo</asp:HyperLink></li>--%>
</ul>
