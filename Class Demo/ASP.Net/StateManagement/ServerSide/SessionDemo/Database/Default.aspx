<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="ServerSide_SessionDemo_Database_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 61%;
            height: 118px;
        }
        .style2
        {
            height: 35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table bgcolor="#FFFF99" border="1" class="style1">
            <tr>
                <td>
                    Emp Id</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    EName</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Basic</td>
                <td class="style2" colspan="3">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="First" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" onclick="Button1_Click" Text="Prev" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" onclick="Button1_Click" Text="Next" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" onclick="Button1_Click" Text="Last" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
