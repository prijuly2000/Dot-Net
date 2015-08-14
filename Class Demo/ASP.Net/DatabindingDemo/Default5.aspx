<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" DataKeyNames="Eid" DataSourceID="SqlDataSource1" 
        ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Select Emp">
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Eid" HeaderText="Eid" ReadOnly="True" 
                SortExpression="Eid" />
            <asp:BoundField DataField="EName" HeaderText="EName" SortExpression="EName" />
            <asp:BoundField DataField="Basic" HeaderText="Basic" SortExpression="Basic" />
            <asp:ImageField DataImageUrlField="ImageUrl" HeaderText="Image">
                <ControlStyle BorderWidth="1px" Height="100px" Width="120px" />
            </asp:ImageField>
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:Company1ConnectionString %>" 
        SelectCommand="SELECT * FROM [Emp]"></asp:SqlDataSource>
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
    
    </div>
    <asp:ListBox ID="ListBox1" runat="server" Height="148px" Width="177px">
    </asp:ListBox>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Display" />
    </form>
</body>
</html>
