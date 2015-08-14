<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table style="width: 100%; height: 130px">
        <tr>
            <td style="width: 269px">
                <asp:WebPartManager ID="WebPartManager1" runat="server">
                </asp:WebPartManager>
            </td>
            <td>
                <asp:WebPartZone ID="WebPartZone3" runat="server" BorderColor="#CCCCCC" 
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
            <td style="width: 269px">
                <asp:WebPartZone ID="WebPartZone1" runat="server" BorderColor="#CCCCCC" 
                    Font-Names="Verdana" Padding="6">
                    <ZoneTemplate>
                        <asp:Wizard Title="My Wizard" ID="Wizard1" runat="server" Height="132px" Width="196px">
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
                    <MenuPopupStyle BackColor="#1C5E55" BorderColor="#CCCCCC" BorderWidth="1px" 
                        Font-Names="Verdana" Font-Size="0.6em">
                    </MenuPopupStyle>
                    <MenuVerbHoverStyle BackColor="#E3EAEB" BorderColor="#CCCCCC" BorderWidth="1px" 
                        BorderStyle="Solid" ForeColor="#333333"></MenuVerbHoverStyle>
                    <MenuVerbStyle BorderColor="#1C5E55" BorderWidth="1px" BorderStyle="Solid" 
                        ForeColor="White"></MenuVerbStyle>
                    <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White">
                    </TitleBarVerbStyle>
                    <EmptyZoneTextStyle Font-Size="0.8em"></EmptyZoneTextStyle>
                    <HeaderStyle HorizontalAlign="Center" Font-Size="0.7em" ForeColor="#CCCCCC">
                    </HeaderStyle>
                    <PartChromeStyle BackColor="#E3EAEB" BorderColor="#C5BBAF" Font-Names="Verdana" 
                        ForeColor="#333333"></PartChromeStyle>
                    <PartStyle Font-Size="0.8em" ForeColor="#333333"></PartStyle>
                    <PartTitleStyle BackColor="#1C5E55" Font-Bold="True" Font-Size="0.8em" 
                        ForeColor="White"></PartTitleStyle>
                </asp:WebPartZone>
            </td>
            <td>
                <asp:WebPartZone ID="WebPartZone2" runat="server" BorderColor="#CCCCCC" 
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
    </table>
</asp:Content>

<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <asp:Label ID="Label1" runat="server" Font-Names="Algerian" 
    Font-Size="XX-Large" ForeColor="#CC0000" Text="HOME Page"></asp:Label>
</asp:Content>


