<%@ Page Language="C#" AutoEventWireup="true" CodeFile="secured.aspx.cs" Inherits="secured" %>

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
    
        <asp:Label ID="Label1" runat="server" Font-Names="Algerian" 
            Font-Size="XX-Large" ForeColor="Red" Text="Secured Page"></asp:Label>
    
    </div>
    <asp:LoginStatus ID="LoginStatus1" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LoginName ID="LoginName1" runat="server" />
    <table bgcolor="#CCFFFF" border="1" class="style1">
        <tr>
            <td>
                <asp:WebPartManager ID="WebPartManager1" runat="server">
                </asp:WebPartManager>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>Browse</asp:ListItem>
                    <asp:ListItem>Design</asp:ListItem>
                    <asp:ListItem>Catalog</asp:ListItem>
                    <asp:ListItem>Edit</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:WebPartZone ID="WebPartZone1" runat="server" BorderColor="#CCCCCC" 
                    Font-Names="Verdana" Padding="6">
                    <ZoneTemplate>
                        <asp:Calendar ID="Calendar1" Title="My Calender" runat="server"></asp:Calendar>
                    </ZoneTemplate>
                    <MenuLabelHoverStyle ForeColor="#E2DED6"></MenuLabelHoverStyle>
                    <MenuLabelStyle ForeColor="White"></MenuLabelStyle>
                    <MenuPopupStyle BackColor="#5D7B9D" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.6em">
                    </MenuPopupStyle>
                    <MenuVerbHoverStyle BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderWidth="1px" BorderStyle="Solid" ForeColor="#333333">
                    </MenuVerbHoverStyle>
                    <MenuVerbStyle BorderColor="#5D7B9D" BorderWidth="1px" BorderStyle="Solid" ForeColor="White">
                    </MenuVerbStyle>
                    <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White">
                    </TitleBarVerbStyle>
                    <EmptyZoneTextStyle Font-Size="0.8em"></EmptyZoneTextStyle>
                    <HeaderStyle HorizontalAlign="Center" Font-Size="0.7em" ForeColor="#CCCCCC">
                    </HeaderStyle>
                    <PartChromeStyle BackColor="#F7F6F3" BorderColor="#E2DED6" Font-Names="Verdana" ForeColor="White">
                    </PartChromeStyle>
                    <PartStyle Font-Size="0.8em" ForeColor="#333333"></PartStyle>
                    <PartTitleStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.8em" ForeColor="White">
                    </PartTitleStyle>
                </asp:WebPartZone>
            </td>
            <td>
                <asp:WebPartZone ID="WebPartZone2" runat="server" BorderColor="#CCCCCC" 
                    Font-Names="Verdana" Padding="6">
                    <ZoneTemplate>
                        <asp:FileUpload Title="My FileUpload" ID="FileUpload1" runat="server" />
                    </ZoneTemplate>
                    <MenuLabelHoverStyle ForeColor="#D1DDF1"></MenuLabelHoverStyle>
                    <MenuLabelStyle ForeColor="White"></MenuLabelStyle>
                    <MenuPopupStyle BackColor="#507CD1" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.6em">
                    </MenuPopupStyle>
                    <MenuVerbHoverStyle BackColor="#EFF3FB" BorderColor="#CCCCCC" BorderWidth="1px" BorderStyle="Solid" ForeColor="#333333">
                    </MenuVerbHoverStyle>
                    <MenuVerbStyle BorderColor="#507CD1" BorderWidth="1px" BorderStyle="Solid" ForeColor="White">
                    </MenuVerbStyle>
                    <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White">
                    </TitleBarVerbStyle>
                    <EmptyZoneTextStyle Font-Size="0.8em"></EmptyZoneTextStyle>
                    <HeaderStyle HorizontalAlign="Center" Font-Size="0.7em" ForeColor="#CCCCCC">
                    </HeaderStyle>
                    <PartChromeStyle BackColor="#EFF3FB" BorderColor="#D1DDF1" Font-Names="Verdana" ForeColor="#333333">
                    </PartChromeStyle>
                    <PartStyle Font-Size="0.8em" ForeColor="#333333"></PartStyle>
                    <PartTitleStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.8em" ForeColor="White">
                    </PartTitleStyle>
                </asp:WebPartZone>
            </td>
        </tr>
        <tr>
            <td>
                <asp:WebPartZone ID="WebPartZone3" runat="server" BorderColor="#CCCCCC" 
                    Font-Names="Verdana" Padding="6">
                    <ZoneTemplate>
                        <asp:Wizard Title="My Wizard" ID="Wizard1" runat="server" Height="159px" Width="215px">
                            <WizardSteps>
                                <asp:WizardStep runat="server" title="Step 1">
                                </asp:WizardStep>
                                <asp:WizardStep runat="server" title="Step 2">
                                </asp:WizardStep>
                            </WizardSteps>
                        </asp:Wizard>
                    </ZoneTemplate>
                    <MenuLabelHoverStyle ForeColor="Yellow"></MenuLabelHoverStyle>
                    <MenuLabelStyle ForeColor="#333333"></MenuLabelStyle>
                    <MenuPopupStyle BackColor="#1C5E55" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.6em">
                    </MenuPopupStyle>
                    <MenuVerbHoverStyle BackColor="#E3EAEB" BorderColor="#CCCCCC" BorderWidth="1px" BorderStyle="Solid" ForeColor="#333333">
                    </MenuVerbHoverStyle>
                    <MenuVerbStyle BorderColor="#1C5E55" BorderWidth="1px" BorderStyle="Solid" ForeColor="White">
                    </MenuVerbStyle>
                    <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White">
                    </TitleBarVerbStyle>
                    <EmptyZoneTextStyle Font-Size="0.8em"></EmptyZoneTextStyle>
                    <HeaderStyle HorizontalAlign="Center" Font-Size="0.7em" ForeColor="#CCCCCC">
                    </HeaderStyle>
                    <PartChromeStyle BackColor="#E3EAEB" BorderColor="#C5BBAF" Font-Names="Verdana" ForeColor="#333333">
                    </PartChromeStyle>
                    <PartStyle Font-Size="0.8em" ForeColor="#333333"></PartStyle>
                    <PartTitleStyle BackColor="#1C5E55" Font-Bold="True" Font-Size="0.8em" ForeColor="White">
                    </PartTitleStyle>
                </asp:WebPartZone>
            </td>
            <td>
                <asp:WebPartZone ID="WebPartZone4" runat="server" BorderColor="#CCCCCC" 
                    Font-Names="Verdana" Padding="6">
                    <ZoneTemplate>
                        <asp:Login Title="My Login" ID="Login1" runat="server">
                        </asp:Login>
                    </ZoneTemplate>
                    <MenuLabelHoverStyle ForeColor="#FFCC66"></MenuLabelHoverStyle>
                    <MenuLabelStyle ForeColor="White"></MenuLabelStyle>
                    <MenuPopupStyle BackColor="#990000" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.6em">
                    </MenuPopupStyle>
                    <MenuVerbHoverStyle BackColor="#FFFBD6" BorderColor="#CCCCCC" BorderWidth="1px" BorderStyle="Solid" ForeColor="#333333">
                    </MenuVerbHoverStyle>
                    <MenuVerbStyle BorderColor="#990000" BorderWidth="1px" BorderStyle="Solid" ForeColor="White">
                    </MenuVerbStyle>
                    <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White">
                    </TitleBarVerbStyle>
                    <EmptyZoneTextStyle Font-Size="0.8em"></EmptyZoneTextStyle>
                    <HeaderStyle HorizontalAlign="Center" Font-Size="0.7em" ForeColor="#CCCCCC">
                    </HeaderStyle>
                    <PartChromeStyle BackColor="#FFFBD6" BorderColor="#FFCC66" Font-Names="Verdana" ForeColor="#333333">
                    </PartChromeStyle>
                    <PartStyle Font-Size="0.8em" ForeColor="#333333"></PartStyle>
                    <PartTitleStyle BackColor="#990000" Font-Bold="True" Font-Size="0.8em" ForeColor="White">
                    </PartTitleStyle>
                </asp:WebPartZone>
            </td>
        </tr>
        <tr>
            <td>
                <asp:CatalogZone ID="CatalogZone1" runat="server" BackColor="#E3EAEB" 
                    BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana" Padding="6">
                    <ZoneTemplate>
                        <asp:PageCatalogPart ID="PageCatalogPart1" runat="server" />
                    </ZoneTemplate>
                    <PartLinkStyle Font-Size="0.8em"></PartLinkStyle>
                    <SelectedPartLinkStyle Font-Size="0.8em"></SelectedPartLinkStyle>
                    <EditUIStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333">
                    </EditUIStyle>
                    <HeaderVerbStyle Font-Bold="False" Font-Size="0.8em" Font-Underline="False" ForeColor="#333333">
                    </HeaderVerbStyle>
                    <InstructionTextStyle Font-Size="0.8em" ForeColor="#333333">
                    </InstructionTextStyle>
                    <LabelStyle Font-Size="0.8em" ForeColor="#333333"></LabelStyle>
                    <EmptyZoneTextStyle Font-Size="0.8em" ForeColor="#333333"></EmptyZoneTextStyle>
                    <FooterStyle HorizontalAlign="Right" BackColor="#C5BBAF"></FooterStyle>
                    <HeaderStyle BackColor="#C5BBAF" Font-Bold="True" Font-Size="0.8em" ForeColor="#333333">
                    </HeaderStyle>
                    <PartChromeStyle BorderColor="#C5BBAF" BorderWidth="1px" BorderStyle="Solid">
                    </PartChromeStyle>
                    <PartStyle BorderColor="#E3EAEB" BorderWidth="5px"></PartStyle>
                    <PartTitleStyle BackColor="#1C5E55" Font-Bold="True" Font-Size="0.8em" ForeColor="White">
                    </PartTitleStyle>
                    <VerbStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333">
                    </VerbStyle>
                </asp:CatalogZone>
            </td>
            <td>
                <asp:EditorZone ID="EditorZone1" runat="server" BackColor="#EFF3FB" 
                    BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana" Padding="6">
                    <ZoneTemplate>
                        


                        <asp:BehaviorEditorPart ID="BehaviorEditorPart1" runat="server" />

                    </ZoneTemplate>
                    <EditUIStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333">
                    </EditUIStyle>
                    <HeaderVerbStyle Font-Bold="False" Font-Size="0.8em" Font-Underline="False" ForeColor="#333333">
                    </HeaderVerbStyle>
                    <InstructionTextStyle Font-Size="0.8em" ForeColor="#333333">
                    </InstructionTextStyle>
                    <LabelStyle Font-Size="0.8em" ForeColor="#333333"></LabelStyle>
                    <EmptyZoneTextStyle Font-Size="0.8em" ForeColor="#333333"></EmptyZoneTextStyle>
                    <ErrorStyle Font-Size="0.8em"></ErrorStyle>
                    <FooterStyle HorizontalAlign="Right" BackColor="#D1DDF1"></FooterStyle>
                    <HeaderStyle BackColor="#D1DDF1" Font-Bold="True" Font-Size="0.8em" ForeColor="#333333">
                    </HeaderStyle>
                    <PartChromeStyle BorderColor="#D1DDF1" BorderWidth="1px" BorderStyle="Solid">
                    </PartChromeStyle>
                    <PartStyle BorderColor="#EFF3FB" BorderWidth="5px"></PartStyle>
                    <PartTitleStyle Font-Bold="True" Font-Size="0.8em" ForeColor="#333333">
                    </PartTitleStyle>
                    <VerbStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333">
                    </VerbStyle>
                </asp:EditorZone>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
