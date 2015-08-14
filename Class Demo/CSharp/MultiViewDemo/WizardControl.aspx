<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WizardControl.aspx.cs" Inherits="WizardControl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="3" BackColor="#F7F6F3" 
            BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" 
            Font-Names="Verdana" Font-Size="0.8em" Height="248px" Width="245px" 
            onfinishbuttonclick="Wizard1_FinishButtonClick">
            <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" 
                Font-Size="0.9em" ForeColor="White" HorizontalAlign="Left" />
            <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
                BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
                ForeColor="#284775" />
            <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" 
                Height="20px" />
            <SideBarStyle BackColor="#7C6F57" BorderWidth="0px" Font-Size="0.9em" 
                VerticalAlign="Middle" BorderStyle="Ridge" Width="20px" />
            <StepStyle BorderWidth="0px" ForeColor="#5D7B9D" />
            <WizardSteps>
               
               
                <asp:WizardStep runat="server" title="Welcome">
                    Welcome to the Wizard Party.....
                </asp:WizardStep>
                

                <asp:WizardStep runat="server" title="Start">
                    First Name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    Last Nme<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </asp:WizardStep>
               
                <asp:WizardStep runat="server" Title="Continued">
                </asp:WizardStep>
               
                <asp:WizardStep runat="server" Title="Final">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    
    </div>
    </form>
</body>
</html>
