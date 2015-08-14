<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

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
            width: 217px;
        }
    </style>
</head>
<body bgcolor="#ccffff">
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>First View</asp:ListItem>
            <asp:ListItem>Second View</asp:ListItem>
            <asp:ListItem>Third View</asp:ListItem>
        </asp:DropDownList>
    
    </div>
    <table class="style1">
        <tr>
            <td class="style2">
                <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                    <asp:View ID="View1" runat="server">
                        <strong>First View<br /> </strong>
                        <asp:Login ID="Login1" runat="server" BackColor="#FFFBD6" BorderColor="#FFDFAD" 
                            BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                            Font-Size="0.8em" ForeColor="#333333" Height="151px" TextLayout="TextOnTop" 
                            Width="205px">
                            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                            <LoginButtonStyle BackColor="White" BorderColor="#CC9966" BorderStyle="Solid" 
                                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" />
                            <TextBoxStyle Font-Size="0.8em" />
                            <TitleTextStyle BackColor="#990000" Font-Bold="True" Font-Size="0.9em" 
                                ForeColor="White" />
                        </asp:Login>
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <strong>Second View<br /> </strong>
                        <asp:Wizard ID="Wizard1" runat="server" BackColor="#FFFBD6" 
                            BorderColor="#FFDFAD" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
                            Height="111px" Width="179px">
                            <HeaderStyle BackColor="#FFCC66" BorderColor="#FFFBD6" BorderStyle="Solid" 
                                BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="#333333" 
                                HorizontalAlign="Center" />
                            <NavigationButtonStyle BackColor="White" BorderColor="#CC9966" 
                                BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
                                ForeColor="#990000" />
                            <SideBarButtonStyle ForeColor="White" />
                            <SideBarStyle BackColor="#990000" Font-Size="0.9em" VerticalAlign="Top" />
                            <WizardSteps>
                                <asp:WizardStep runat="server" title="Step 1">
                                </asp:WizardStep>
                                <asp:WizardStep runat="server" title="Step 2">
                                </asp:WizardStep>
                            </WizardSteps>
                        </asp:Wizard>
                    </asp:View>
                    <asp:View ID="View3" runat="server">
                        <strong>Third View<br />
                        <br />
                        </strong>
                        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" BackColor="#F7F7DE" 
                            BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" 
                            Font-Names="Verdana" Font-Size="10pt">
                            <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
                                BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                                ForeColor="#284775" />
                            <CreateUserButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
                                BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                                ForeColor="#284775" />
                            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
                            <WizardSteps>
                                <asp:CreateUserWizardStep runat="server" />
                                <asp:CompleteWizardStep runat="server" />
                            </WizardSteps>
                            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" 
                                HorizontalAlign="Center" />
                            <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
                                BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                                ForeColor="#284775" />
                            <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" 
                                ForeColor="#FFFFFF" />
                            <SideBarStyle BackColor="#7C6F57" BorderWidth="0px" Font-Size="0.9em" 
                                VerticalAlign="Top" />
                            <StepStyle BorderWidth="0px" />
                        </asp:CreateUserWizard>
                    </asp:View>
                </asp:MultiView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
