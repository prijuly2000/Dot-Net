<%@ Page Language="C#" AutoEventWireup="true" CodeFile="First.aspx.cs" Inherits="ClientSide_QueryStringDemo_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 117px;
        }
    </style>
</head>
<body style="height: 87px; width: 263px">
    <form id="form1" runat="server">
    <div>
    
        <table bgcolor="#FFCCCC" border="1" class="style1">
            <tr>
                <td class="style2">
                    Enter First Name</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Enter Last Name</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        Text="Send Data" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
