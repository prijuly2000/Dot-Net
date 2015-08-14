<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" 
        BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
        CellPadding="4" DataKeyNames="Eid" DataSourceID="SqlDataSource1" 
        GridLines="Both">
        <EditItemTemplate>
            Eid:
            <asp:Label ID="EidLabel1" runat="server" Text='<%# Eval("Eid") %>' />
            <br />
            EName:
            <asp:TextBox ID="ENameTextBox" runat="server" Text='<%# Bind("EName") %>' />
            <br />
            Basic:
            <asp:TextBox ID="BasicTextBox" runat="server" Text='<%# Bind("Basic") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <EditRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <FooterTemplate>
            ----------End----------
        </FooterTemplate>
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <HeaderTemplate>
            -----Emp Info --------
        </HeaderTemplate>
        <InsertItemTemplate>
            Eid:
            <asp:TextBox ID="EidTextBox" runat="server" Text='<%# Bind("Eid") %>' />
            <br />
            EName:
            <asp:TextBox ID="ENameTextBox" runat="server" Text='<%# Bind("EName") %>' />
            <br />
            Basic:
            <asp:TextBox ID="BasicTextBox" runat="server" Text='<%# Bind("Basic") %>' />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            The Emp Id is
            <asp:Label ID="EidLabel" runat="server" Text='<%# Eval("Eid") %>' />
            &nbsp;and his name is
            <asp:Label ID="ENameLabel" runat="server" Text='<%# Bind("EName") %>' />
            , earns&nbsp;
            <asp:Label ID="BasicLabel" runat="server" Text='<%# Bind("Basic") %>' />
            .<br />&nbsp;<asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                CommandName="Edit" Text="Edit" />
            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" 
                CommandName="Delete" Text="Delete" />
            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                CommandName="New" Text="New" />
        </ItemTemplate>
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
    </asp:FormView>
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
    </form>
</body>
</html>
