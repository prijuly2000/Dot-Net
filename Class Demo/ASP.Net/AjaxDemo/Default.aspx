<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>First</asp:ListItem>
            <asp:ListItem>Second</asp:ListItem>
            <asp:ListItem>Third</asp:ListItem>
            <asp:ListItem>Fifth</asp:ListItem>
            <asp:ListItem>Sixth</asp:ListItem>
            <asp:ListItem>Fourth</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem>First</asp:ListItem>
                <asp:ListItem>Second</asp:ListItem>
                <asp:ListItem>Third</asp:ListItem>
                <asp:ListItem>Fifth</asp:ListItem>
                <asp:ListItem>Sixth</asp:ListItem>
                <asp:ListItem>Fourth</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <table class="style1">
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
                            DataSourceID="SqlDataSource1" DataTextField="EName" DataValueField="Eid">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:Company1ConnectionString %>" 
                            SelectCommand="SELECT * FROM [Emp]"></asp:SqlDataSource>
                    </td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                            BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
                            CellPadding="4" DataKeyNames="Eid" DataSourceID="SqlDataSource2">
                            <Columns>
                                <asp:BoundField DataField="Eid" HeaderText="Eid" ReadOnly="True" 
                                    SortExpression="Eid" />
                                <asp:BoundField DataField="EName" HeaderText="EName" SortExpression="EName" />
                                <asp:BoundField DataField="Basic" HeaderText="Basic" SortExpression="Basic" />
                                <asp:BoundField DataField="ImageUrl" HeaderText="ImageUrl" 
                                    SortExpression="ImageUrl" />
                            </Columns>
                            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                            <RowStyle BackColor="White" ForeColor="#330099" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                            <SortedAscendingCellStyle BackColor="#FEFCEB" />
                            <SortedAscendingHeaderStyle BackColor="#AF0101" />
                            <SortedDescendingCellStyle BackColor="#F6F0C0" />
                            <SortedDescendingHeaderStyle BackColor="#7E0000" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:Company1ConnectionString %>" 
                            SelectCommand="SELECT * FROM [Emp] WHERE ([Eid] = @Eid)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="DropDownList3" DefaultValue="111" Name="Eid" 
                                    PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
