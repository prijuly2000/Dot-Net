<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
            height: 23px;
        }
    </style>
</head>
<body style="height: 285px; width: 667px">
    <form id="form1" runat="server">
    <div>
    
        <table  align="center" bgcolor="#FFCCCC" border="1" 
            style="height: 247px; width: 206px">
            <tr align="center">
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Names="Algerian" 
                        Font-Size="XX-Large" ForeColor="#CC0099" meta:resourcekey="Label1Resource1" 
                        Text="Label"></asp:Label>
                </td>
            </tr>
            <tr align="center">
                <td class="style2">
                    <asp:Image ID="Image1" runat="server" Height="146px" 
                        meta:resourcekey="Image1Resource1" Width="140px" />
                </td>
            </tr>
            <tr align="center">
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" 
                        meta:resourcekey="HyperLink1Resource1" NavigateUrl="~/Default.aspx" 
                        style="font-weight: 700">Refresh</asp:HyperLink>
                &nbsp;
                    <asp:HyperLink ID="HyperLink2" runat="server" 
                        meta:resourcekey="HyperLink1Resource1" NavigateUrl="~/Default2.aspx" 
                        style="font-weight: 700" Text="Next"></asp:HyperLink>
                </td>
            </tr>
            <tr align="center">
                <td>
                    <asp:ImageButton ID="ImageButton1" runat="server" BorderColor="#CC0000" 
                        BorderStyle="Solid" Height="32px" ImageUrl="~/Images/england.jpeg" 
                        PostBackUrl="~/Default.aspx?Language=en-US" Width="49px" />
&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton2" runat="server" BorderColor="#CC0000" 
                        BorderStyle="Solid" Height="32px" ImageUrl="~/Images/japan.jpeg" 
                        PostBackUrl="~/Default.aspx?Language=ja-JP" Width="49px" />
                </td>
            </tr>
            <tr align="center">
                <td>
                    <asp:Label ID="Label2" runat="server" Font-Names="Algerian" 
                        Font-Size="XX-Large" ForeColor="#CC0099" meta:resourcekey="Label1Resource1" 
                        Text="Label"></asp:Label>
                </td>
            </tr>
            <tr align="center">
                <td>
                    <asp:Label ID="Label3" runat="server" Font-Names="Algerian" 
                        Font-Size="XX-Large" ForeColor="#CC0099" meta:resourcekey="Label1Resource1" 
                        Text="Label"></asp:Label>
                </td>
            </tr>
            <tr align="center">
                <td>
                    <asp:Label ID="Label4" runat="server" Font-Names="Algerian" 
                        Font-Size="XX-Large" ForeColor="#CC0099" meta:resourcekey="Label1Resource1" 
                        Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
