<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Create.aspx.cs" Inherits="Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" 
            AutoGenerateRows="False" DataKeyNames="Roll" DataSourceID="SqlDataSource1" 
            Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="Roll" HeaderText="Roll" ReadOnly="True" 
                    SortExpression="Roll" />
                <asp:BoundField DataField="Lname" HeaderText="Lname" SortExpression="Lname" />
                <asp:BoundField DataField="Fname" HeaderText="Fname" SortExpression="Fname" />
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                <asp:CommandField NewText="Create" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConflictDetection="CompareAllValues" 
            ConnectionString="<%$ ConnectionStrings:database1ConnectionString %>" 
            DeleteCommand="DELETE FROM [student] WHERE [Roll] = @original_Roll AND (([Lname] = @original_Lname) OR ([Lname] IS NULL AND @original_Lname IS NULL)) AND (([Fname] = @original_Fname) OR ([Fname] IS NULL AND @original_Fname IS NULL)) AND (([Date] = @original_Date) OR ([Date] IS NULL AND @original_Date IS NULL))" 
            InsertCommand="INSERT INTO [student] ([Roll], [Lname], [Fname], [Date]) VALUES (@Roll, @Lname, @Fname, @Date)" 
            OldValuesParameterFormatString="original_{0}" 
            onselecting="SqlDataSource1_Selecting" SelectCommand="SELECT * FROM [student]" 
            UpdateCommand="UPDATE [student] SET [Lname] = @Lname, [Fname] = @Fname, [Date] = @Date WHERE [Roll] = @original_Roll AND (([Lname] = @original_Lname) OR ([Lname] IS NULL AND @original_Lname IS NULL)) AND (([Fname] = @original_Fname) OR ([Fname] IS NULL AND @original_Fname IS NULL)) AND (([Date] = @original_Date) OR ([Date] IS NULL AND @original_Date IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_Roll" Type="Int32" />
                <asp:Parameter Name="original_Lname" Type="String" />
                <asp:Parameter Name="original_Fname" Type="String" />
                <asp:Parameter Name="original_Date" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Roll" Type="Int32" />
                <asp:Parameter Name="Lname" Type="String" />
                <asp:Parameter Name="Fname" Type="String" />
                <asp:Parameter Name="Date" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Lname" Type="String" />
                <asp:Parameter Name="Fname" Type="String" />
                <asp:Parameter Name="Date" Type="String" />
                <asp:Parameter Name="original_Roll" Type="Int32" />
                <asp:Parameter Name="original_Lname" Type="String" />
                <asp:Parameter Name="original_Fname" Type="String" />
                <asp:Parameter Name="original_Date" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Display.aspx">Diplay List</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
