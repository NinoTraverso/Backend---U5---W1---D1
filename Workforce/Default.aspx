<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Workforce.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />

    <div class="d-flex flex-row  align-content-center align-items-center">
        <div class="w-50 h-100 d-flex justify-content-center align-content-center"">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Content/Assets/workers.png" CssClass="w-50 h-100"/>
        </div>
        <div>
        <h3>Gesitisci dipentendi e pagamenti!</h3>
        <h5>Con questa applicazione potrete:</h5> 
        <h6>aggiungere tutti i vostri dipendenti, coi rispettivi dati; </h6>
        <h6>aggiungere tutti i pagamenti e gli anticipi fatti per ogni dipendente</h6>
        <h6>visualizzare la lista dei vostri dipendenti registrati e i pagamenti o anticipi fatti a ciascuno</h6>
        </div>
    </div>
    </asp:Content>
