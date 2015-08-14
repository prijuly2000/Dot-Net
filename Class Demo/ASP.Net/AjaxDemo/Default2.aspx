<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Click Here" />
            &nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <asp:Image ID="Image1" runat="server" Height="180px" 
                        ImageUrl="~/Images/loading.gif" Width="189px" />
                    <asp:Label ID="Label2" runat="server" Font-Names="Algerian" 
                        Font-Size="XX-Large" ForeColor="Red" Text="Still Loading...."></asp:Label>
                </ProgressTemplate>
            </asp:UpdateProgress>
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
