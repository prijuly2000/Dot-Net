<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" BackColor="#E6E2D8" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" 
            Font-Names="Verdana" Font-Size="0.8em" Height="185px" 
            onfinishbuttonclick="Wizard1_FinishButtonClick" Width="264px">
            <HeaderStyle BackColor="#666666" BorderColor="#E6E2D8" BorderStyle="Solid" 
                BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="White" 
                HorizontalAlign="Center" />
            <NavigationButtonStyle BackColor="White" BorderColor="#C5BBAF" 
                BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
                ForeColor="#1C5E55" />
            <SideBarButtonStyle ForeColor="White" />
            <SideBarStyle BackColor="#1C5E55" Font-Size="0.9em" VerticalAlign="Top" />
            <StepStyle BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderStyle="Solid" 
                BorderWidth="2px" />
            <WizardSteps>
                <asp:WizardStep runat="server" title="Welcome">
                    Welcome To<br /> Ticket Booking System
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Personal Details">
                    FirstName
                    <asp:TextBox ID="TextBox1" runat="server" Width="81px"></asp:TextBox>
                    <br />
                    <br />
                    LastName<asp:TextBox ID="TextBox2" runat="server" Width="81px"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Source">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Mumbai</asp:ListItem>
                        <asp:ListItem>Chennai</asp:ListItem>
                        <asp:ListItem>Delhi</asp:ListItem>
                        <asp:ListItem>Goa</asp:ListItem>
                        <asp:ListItem>Bhopal</asp:ListItem>
                    </asp:DropDownList>
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Designation">
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>Pune</asp:ListItem>
                        <asp:ListItem>Kolhapur</asp:ListItem>
                        <asp:ListItem>Nagpur</asp:ListItem>
                        <asp:ListItem>Sholapur</asp:ListItem>
                        <asp:ListItem>Nasik</asp:ListItem>
                    </asp:DropDownList>
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Date of Journey">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
                        BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" 
                        DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" 
                        ForeColor="#003399" Height="148px" Width="157px">
                        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" 
                            Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                        <WeekendDayStyle BackColor="#CCCCFF" />
                    </asp:Calendar>
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Number of Tickets">
                    <asp:DropDownList ID="DropDownList3" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                    </asp:DropDownList>
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Confirmation">
                    Do you wish to confirm<br />
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Yes,I Confirm" />
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Result">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    
    </div>
    </form>
</body>
</html>
