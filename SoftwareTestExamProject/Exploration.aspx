<%@ Page Title="Exploration" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Exploration.aspx.cs" Inherits="SoftwareTestExamProject.Exploration" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="container body-content">
        <h1>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonUp" runat="server" OnClick="ButtonUp_Click" Text="Up" />
        </h1>
        <h1 style="margin-left: 440px">
            <asp:Button ID="ButtonLeft" runat="server" OnClick="ButtonLeft_Click" Text="Left" />
&nbsp;
            <asp:Label ID="mapLabel" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;
            <asp:Button ID="ButtonRight" runat="server" OnClick="ButtonRight_Click" Text="Right" />
        </h1>
        <p style="margin-left: 480px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonDown" runat="server" OnClick="ButtonDown_Click" Text="Down" />
        </p>
    </div>
</asp:Content>
