<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" 
AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormDemo._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script src="Scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Products</h2>
    <table>
        <thead>
        <tr><th>Name</th><th>Price</th></tr>
        </thead>
        <tbody id="products">
        </tbody>
    </table>
</asp:Content>