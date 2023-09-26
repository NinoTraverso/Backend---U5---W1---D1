<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewDB.aspx.cs" Inherits="Workforce.ViewDB" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    

    <h1>Lista Dipendenti:</h1>
    <div class="mx-5 text-center">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" CssClass="table table-bordered table-striped table-hover">
        <HeaderStyle CssClass="table-primary" />
        <RowStyle CssClass="table table-light" />
        <AlternatingRowStyle CssClass="table-secondary" />
        
    </asp:GridView>
    </div>

    <h1>Lista Pagmenti:</h1>
<div class="mx-5 text-center">
<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="true" CssClass="table table-bordered table-striped table-hover">
    <HeaderStyle CssClass="table-primary" />
    <RowStyle CssClass="table table-light" />
    <AlternatingRowStyle CssClass="table-secondary" />
</asp:GridView>
</div>
</asp:Content>
