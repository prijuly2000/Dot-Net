<%@ Page Language="C#" AutoEventWireup="true" CodeFile="first.aspx.cs" Inherits="first" %>

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
            width: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table bgcolor="#FFCCCC" border="1" class="style1">
            <tr>
                <td class="style2">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:Company1ConnectionString %>" 
                        SelectCommand="SELECT * FROM [Emp]"></asp:SqlDataSource>
                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                        AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
                        DataKeyNames="Eid" DataSourceID="SqlDataSource1" ForeColor="#333333" 
                        GridLines="None" Height="174px" 
                        onselectedindexchanged="GridView1_SelectedIndexChanged" PageSize="5" 
                        Width="272px">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="Eid" HeaderText="Eid" ReadOnly="True" 
                                SortExpression="Eid" />
                            <asp:BoundField DataField="EName" HeaderText="EName" SortExpression="EName" />
                            <asp:BoundField DataField="Basic" HeaderText="Basic" SortExpression="Basic" />
                        </Columns>
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                        <SortedDescendingHeaderStyle BackColor="#820000" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        ConflictDetection="CompareAllValues" 
                        ConnectionString="<%$ ConnectionStrings:Company1ConnectionString %>" 
                        DeleteCommand="DELETE FROM [Emp] WHERE [Eid] = @original_Eid AND (([EName] = @original_EName) OR ([EName] IS NULL AND @original_EName IS NULL)) AND (([Basic] = @original_Basic) OR ([Basic] IS NULL AND @original_Basic IS NULL))" 
                        InsertCommand="INSERT INTO [Emp] ([Eid], [EName], [Basic]) VALUES (@Eid, @EName, @Basic)" 
                        OldValuesParameterFormatString="original_{0}" 
                        SelectCommand="SELECT * FROM [Emp]" 
                        UpdateCommand="UPDATE [Emp] SET [EName] = @EName, [Basic] = @Basic WHERE [Eid] = @original_Eid AND (([EName] = @original_EName) OR ([EName] IS NULL AND @original_EName IS NULL)) AND (([Basic] = @original_Basic) OR ([Basic] IS NULL AND @original_Basic IS NULL))">
                        <DeleteParameters>
                            <asp:Parameter Name="original_Eid" Type="Int32" />
                            <asp:Parameter Name="original_EName" Type="String" />
                            <asp:Parameter Name="original_Basic" Type="Double" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="Eid" Type="Int32" />
                            <asp:Parameter Name="EName" Type="String" />
                            <asp:Parameter Name="Basic" Type="Double" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="EName" Type="String" />
                            <asp:Parameter Name="Basic" Type="Double" />
                            <asp:Parameter Name="original_Eid" Type="Int32" />
                            <asp:Parameter Name="original_EName" Type="String" />
                            <asp:Parameter Name="original_Basic" Type="Double" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </td>
                <td>
                    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" 
                        AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
                        DataKeyNames="Eid" DataSourceID="SqlDataSource2" ForeColor="#333333" 
                        GridLines="None" Width="308px">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                                ShowSelectButton="True" />
                            <asp:BoundField DataField="Eid" HeaderText="Eid" ReadOnly="True" 
                                SortExpression="Eid" />
                            <asp:BoundField DataField="EName" HeaderText="EName" SortExpression="EName" />
                            <asp:BoundField DataField="Basic" HeaderText="Basic" SortExpression="Basic" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
