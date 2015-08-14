<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 81%;
            height: 309px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Xml ID="Xml1" runat="server" DocumentSource="~/Emp.xml" 
            TransformSource="~/emp.xslt"></asp:Xml>
    
    </div>
    <table class="style1">
        <tr>
            <td>
                <asp:AdRotator ID="AdRotator1" runat="server" 
                    AdvertisementFile="~/adFile.xml" />
            </td>
            <td>
                <asp:AdRotator ID="AdRotator2" runat="server" 
                    AdvertisementFile="~/adFile.xml" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:AdRotator ID="AdRotator3" runat="server" 
                    AdvertisementFile="~/adFile.xml" />
            </td>
            <td>
                <asp:AdRotator ID="AdRotator4" runat="server" 
                    AdvertisementFile="~/adFile.xml" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
