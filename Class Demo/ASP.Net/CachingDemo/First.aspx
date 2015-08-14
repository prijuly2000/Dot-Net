<%@ Page Language="C#" AutoEventWireup="true" CodeFile="First.aspx.cs" Inherits="First" %>
<%@ OutputCache Duration="30" VaryByParam="none" VaryByControl="*" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 42%;
            height: 51px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table bgcolor="#FFCCCC" border="1" class="style1">
            <tr>
                <td>
                    Current Time</td>
                <td>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        Text="Show Time" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>First</asp:ListItem>
                        <asp:ListItem>Second</asp:ListItem>
                        <asp:ListItem>Third</asp:ListItem>
                        <asp:ListItem>Fourth</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 40px">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td style="margin-left: 80px">
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Button" />
                </td>
            </tr>
            <tr>
                <td style="margin-left: 40px">
                    <asp:Literal ID="Literal3" runat="server"></asp:Literal>
                </td>
                <td style="margin-left: 80px">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
