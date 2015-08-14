<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

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
            width: 283px;
        }
    </style>
</head>
<body bgcolor="#ccffff">
    <form id="form1" runat="server">
    <div>
    
    </div>
    <table class="style1">
        <tr>
            <td class="style2">
                <asp:ImageMap ID="ImageMap1" runat="server" Height="198px" 
                    ImageUrl="~/Images/Sunset.jpg" Width="285px">
                    <asp:CircleHotSpot AlternateText="Circle" NavigateUrl="~/Default.aspx" 
                        Radius="60" Target="_blank" X="60" Y="60" />
                    <asp:RectangleHotSpot AlternateText="Rect" Bottom="100" Left="120" 
                        NavigateUrl="~/second.aspx" Right="200" Target="_blank" />
                </asp:ImageMap>
            </td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Upload" />
                <br />
                <br />
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Panel ID="Panel1" runat="server" Height="120px" ScrollBars="Both" 
                    Width="140px">

                    <marquee direction="up">
                    <asp:Image ID="Image1" runat="server" Height="117px" 
                        ImageUrl="~/Images/Sunset.jpg" Width="131px" />
                    <br />
                    <br />
                    <asp:Image ID="Image2" runat="server" Height="117px" 
                        ImageUrl="~/Images/Blue hills.jpg" Width="131px" />
                    <br />
                    <br />
                    <asp:Image ID="Image3" runat="server" Height="117px" 
                        ImageUrl="~/Images/Water lilies.jpg" Width="131px" />
                    <br />
                    <br />
                    <asp:Image ID="Image4" runat="server" Height="117px" 
                        ImageUrl="~/Images/Winter.jpg" Width="131px" />
                        </marquee>
                </asp:Panel>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
