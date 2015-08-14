<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="ClientSide_HiddenFieldDemo_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 77%;
            height: 130px;
        }
        .style2
        {
            width: 120px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2">
                    Enter Data</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 93px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Button ID="Button1" runat="server" Height="35px" Text="Store" 
                        Width="77px" />
                </td>
                <td>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                    <br />
                    <asp:HiddenField ID="HiddenField1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                        Text="Click Here " />
                </td>
                <td>
                    &nbsp; &nbsp;<asp:HiddenField ID="NoOfClicks" runat="server" />
                    <br />
                    Number of Clicks : 
                    <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
