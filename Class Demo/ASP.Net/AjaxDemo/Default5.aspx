<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

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
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                    <asp:View ID="View1" runat="server">
                        <asp:Image ID="Image1" runat="server" Height="165px" 
                            ImageUrl="~/Images/a1.jpeg" Width="180px" />
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <asp:Image ID="Image2" runat="server" Height="165px" 
                            ImageUrl="~/Images/b1.jpeg" Width="180px" />
                    </asp:View>
                    <asp:View ID="View3" runat="server">
                        <asp:Image ID="Image3" runat="server" Height="165px" 
                            ImageUrl="~/Images/c1.jpeg" Width="180px" />
                    </asp:View>
                    <asp:View ID="View4" runat="server">
                        <asp:Image ID="Image4" runat="server" Height="165px" 
                            ImageUrl="~/Images/d1.jpeg" Width="180px" />
                    </asp:View>
                    <asp:View ID="View5" runat="server">
                        <asp:Image ID="Image5" runat="server" Height="165px" 
                            ImageUrl="~/Images/f1.jpeg" Width="180px" />
                    </asp:View>
                    <asp:View ID="View6" runat="server">
                        <asp:Image ID="Image6" runat="server" Height="165px" 
                            ImageUrl="~/Images/g1.jpeg" Width="180px" />
                    </asp:View>
                </asp:MultiView>
                 <asp:Timer ID="Timer1" runat="server" Interval="2000" ontick="Timer1_Tick">
        </asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>
       
    
    </div>
    </form>
</body>
</html>
