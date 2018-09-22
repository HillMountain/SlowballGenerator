<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SlowballGenerator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:20px;">
            <table>
                <tr>
                    <td>
                        <dx:ASPxListBox ID="ASPxListBox1" runat="server" ValueType="System.String" Width="400" Height="600"></dx:ASPxListBox>
                    </td>
                    <td>
                        <dx:ASPxListBox ID="ASPxListBox2" runat="server" ValueType="System.String" Width="400" Height="600"></dx:ASPxListBox>
                    </td>
                    <td>
                        <dx:ASPxListBox ID="ASPxListBox3" runat="server" ValueType="System.String" Width="400" Height="600"></dx:ASPxListBox>
                    </td>
                </tr>
            </table>
            <br />
            <dx:ASPxButton ID="ASPxButton1" runat="server" Text="ASPxButton" OnClick="ASPxButton1_Click"></dx:ASPxButton>
            <br />
        </div>
    </form>
</body>
</html>
