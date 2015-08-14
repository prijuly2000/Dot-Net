<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="vaishali.GridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" OnLoad="GridView1_Load" AutoGenerateColumns="False" OnRowDeleted="GridView1_RowDeleted" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="RNo" />
                <asp:BoundField HeaderText="SrNo" DataField="SrNo" Visible="false"></asp:BoundField>
                <asp:BoundField HeaderText="Name" DataField="Name"></asp:BoundField>
                <asp:BoundField HeaderText="PhNo" DataField="PhNo"></asp:BoundField>
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
