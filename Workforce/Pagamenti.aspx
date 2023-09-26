<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pagamenti.aspx.cs" Inherits="Workforce.Pagamenti" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
<h1>PAGAMENTI</h1>

  <div class="d-flex flex-column w-25">
   Data: <asp:TextBox ID="txtDataPagamento" runat="server"></asp:TextBox>
   Stipendio: <asp:TextBox ID="txtStipendio" runat="server"></asp:TextBox>
   Anticipo:<asp:TextBox ID="txtAnticipo" runat="server"></asp:TextBox>
   ID Dipendente:<asp:TextBox ID="txtDipendenteID" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click"/>
  </div>

</asp:Content>
