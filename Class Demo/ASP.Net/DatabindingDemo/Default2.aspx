<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" 
            AutoGenerateRows="False" CellPadding="4" DataKeyNames="Eid" 
            DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None" 
            Height="50px" Width="125px">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
            <EditRowStyle BackColor="#2461BF" />
            <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="Eid" HeaderText="Eid" ReadOnly="True" 
                    SortExpression="Eid" />
                <asp:BoundField DataField="EName" HeaderText="EName" SortExpression="EName" />
                <asp:BoundField DataField="Basic" HeaderText="Basic" SortExpression="Basic" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                    ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
        </asp:DetailsView>
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
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
    
    </div>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
