<%@ Page Title="Exploration" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Exploration.aspx.cs" Inherits="SoftwareTestExamProject.Exploration" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="container body-content">
        <h1>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:button class="buttonleft" id="buttonleft" runat="server" OnClick="ButtonLeft_Click" Text="Left" />

            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="ButtonUp" runat="server" OnClick="ButtonUp_Click" Text="Up" />
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button class="buttonright" ID="ButtonRight" runat="server" OnClick="ButtonRight_Click" Text="Right" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </h1>

       
        <h1 style="margin-left: 320px">

            <asp:Label ID="mapLabel" runat="server" Text="Label"></asp:Label>
            &nbsp;&nbsp;
            </h1>
        <h1 style="margin-left: 400px">
            <asp:Button ID="ButtonDown" runat="server" OnClick="ButtonDown_Click" Text="Down"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;
        </h1>
    </div>
</asp:Content>
