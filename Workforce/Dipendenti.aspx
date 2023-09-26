<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dipendenti.aspx.cs" Inherits="Workforce.Dipendenti" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <h1>DIPENDENTI</h1>

        <h1>Inseriamo un nuovo dipendente:</h1>

    <div class="d-flex flex-column w-25">
    Nome: <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    Cognome: <asp:TextBox ID="txtCognome" runat="server"></asp:TextBox>
    Indirizzo:<asp:TextBox ID="txtIndirizzo" runat="server"></asp:TextBox>
    Codice Fiscale:<asp:TextBox ID="txtCodiceFiscale" runat="server"></asp:TextBox>
    Sposato: <asp:CheckBox ID="CheckBox1" runat="server" />
    Numero figli: <asp:TextBox ID="TextNumeroFigli" runat="server"></asp:TextBox>
    Lavoro: <asp:TextBox ID="TextLavoro" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
    </div>
</asp:Content>
