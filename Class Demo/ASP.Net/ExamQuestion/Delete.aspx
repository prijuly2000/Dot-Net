<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        R u Sure to delete the details?<br />
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
            DataKeyNames="Roll" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="Roll" HeaderText="Roll" ReadOnly="True" 
                    SortExpression="Roll" />
                <asp:BoundField DataField="Lname" HeaderText="Lname" SortExpression="Lname" />
                <asp:BoundField DataField="Fname" HeaderText="Fname" SortExpression="Fname" />
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
            </Fields>
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:database1ConnectionString %>" 
            SelectCommand="SELECT * FROM [student] WHERE ([Roll] = @Roll)">
            <SelectParameters>
                <asp:SessionParameter Name="Roll" SessionField="roll" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            style="height: 26px" Text="Confirm Delete" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Display.aspx">Diplay List</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
