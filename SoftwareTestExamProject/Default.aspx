<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SoftwareTestExamProject._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p>&nbsp;&nbsp;&nbsp;
        </p>
        <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Font-Size="28pt" Text="Create your character"></asp:Label>
        </p>
        <p style="margin-left: 40px">
&nbsp;<asp:Label ID="Label1" runat="server" Text="Input name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Input Health"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Input Damage"></asp:Label>
        </p>
        <p style="margin-left: 40px">
&nbsp;
            <asp:TextBox ID="NameTextBox" runat="server" OnTextChanged="NameTextBox_TextChanged" Width="110px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="HPTextBox" runat="server" OnTextChanged="HPTextBox_TextChanged" Width="110px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="DMGTextBox" runat="server" OnTextChanged="DMGTextBox_TextChanged" Width="110px"></asp:TextBox>
        </p>
        <p style="margin-left: 80px">
&nbsp;&nbsp;
            <asp:Button ID="CreateCharacter" runat="server" OnClick="CreateCharacter_Click" Text="Create Character" Height="73px" Width="313px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="ErrorLabel" runat="server" Text="Label"></asp:Label>
        </p>
    </div>

</asp:Content>
