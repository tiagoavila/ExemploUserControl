<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TesteUserControl._Default" %>

<%@ Register Src="~/UserControl.ascx" TagPrefix="uc1" TagName="UserControl" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <uc1:UserControl runat="server" id="UserControl" />
</asp:Content>
