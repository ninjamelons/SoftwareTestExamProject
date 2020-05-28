<%@ Page Title="Battle" Language="C#" AutoEventWireup="true" CodeBehind="Battle.aspx.cs" Inherits="SoftwareTestExamProject.Battle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 486px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <table style="width: 100%">
                <tr>
                    <td class="auto-style1">Player: 
            <asp:Label ID="playerNameLabel" runat="server" Text="playerName"></asp:Label>
                    </td>
                    <td>Enemy:
                        <asp:Label ID="enemyNameLabel" runat="server" Text="enemyName"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Health: <asp:Label ID="playerHpLabel" runat="server" Text="playerHp"></asp:Label>
                    </td>
                    <td>Health:
                        <asp:Label ID="enemyHpLabel" runat="server" Text="enemyHp"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Damage: <asp:Label ID="playerDmgLabel" runat="server" Text="playerDmg"></asp:Label>
                    </td>
                    <td>Damage:
                        <asp:Label ID="enemyDmgLabel" runat="server" Text="enemyDmg"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <p>
            <asp:Button ID="AttackButton" runat="server" Text="Attack" OnClick="AttackButton_Click" />
        </p>
        <p>
            <asp:Button ID="DefendButton" runat="server" OnClick="DefendButton_Click" Text="Defend" />
        </p>
        <p>
            <asp:Button ID="HealButton" runat="server" Text="Heal" OnClick="HealButton_Click" style="height: 26px" />
        </p>
        <p>
            <asp:Label ID="enemyActionLabel" runat="server" Text="enemyActionLabel"></asp:Label>
&nbsp; |&nbsp;
            <asp:Label ID="playerActionLabel" runat="server" Text="playerActionLabel"></asp:Label>
        </p>
    </form>
</body>
</html>
