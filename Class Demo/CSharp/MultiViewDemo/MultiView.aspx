<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MultiView.aspx.cs" Inherits="MultiView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                Welcome Admin<asp:CheckBoxList ID="CheckBoxList1" runat="server">
                    <asp:ListItem>male</asp:ListItem>
                    <asp:ListItem>female</asp:ListItem>
                    <asp:ListItem>shemale</asp:ListItem>
                </asp:CheckBoxList>
            </asp:View>
            <asp:View ID="View2" runat="server">
                Welcome Student<br />
                <br />
                <br/>
                <asp:Image ID="Image1" runat="server" Height="196px" ImageUrl="~/4.jpg" 
    style="top: -5px; left: 6px; position: relative" Width="238px" />

            </asp:View>
            <asp:View ID="View3" runat="server">
                Welcome Guest<br />
                <br />
                <br />
                <asp:Image ID="Image2" runat="server" ImageUrl="~/4.jpg" 
                    style="top: -5px; left: 6px; position: relative; height: 42px; width: 72px;" />
                <br />
                <br />
            </asp:View>
        </asp:MultiView>
    
    </div>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>Admin</asp:ListItem>
        <asp:ListItem>Guest</asp:ListItem>
        <asp:ListItem>Student</asp:ListItem>
    </asp:DropDownList>
    </form>
</body>
</html>
