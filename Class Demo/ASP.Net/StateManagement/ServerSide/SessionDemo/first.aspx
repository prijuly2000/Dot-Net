<%@ Page Language="C#" AutoEventWireup="true" CodeFile="first.aspx.cs" Inherits="ServerSide_SessionDemo_first" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 53%;
            height: 105px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table bgcolor="#CCFFCC" border="1" class="style1">
            <tr>
                <td>
                    Enter Data</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        Text="Store In Session" />
                </td>
                <td>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" 
                        NavigateUrl="~/ServerSide/SessionDemo/second.aspx">Next Page</asp:HyperLink>
                </td>
                <td>
                    Session ID:<asp:Literal ID="Literal2" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    SessionTimeout :
                    <asp:Literal ID="Literal3" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                        Text="Remove An Item" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Logout" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
