<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script type="text/javascript">
    function CheckEvenOdd(source, args) 
    {    
        //args.Value => Value of TextBox
        var x = parseInt(args.Value);
        if (x % 2 == 0 && x > 20)
        {
            args.IsValid = true;
        }
        else
        {
            args.IsValid = false; //Display the error msg
        }    
    }
</script>
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            width: 139px;
        }
        .style4
        {
            width: 203px;
        }
        .style5
        {
            width: 134px;
        }
    </style>
</head>
<body bgcolor="#ccffff">
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style3">
                    Enter Name</td>
                <td class="style5">
                    <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="A"></asp:TextBox>
                </td>
                <td class="style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TextBox1" ErrorMessage="Please enter your name" 
                        ForeColor="Red" ValidationGroup="A">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    Enter Password</td>
                <td class="style5">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" 
                        ValidationGroup="A"></asp:TextBox>
                </td>
                <td class="style4">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="TextBox2" ErrorMessage="Invalid Password" ForeColor="Red" 
                        ValueToCompare="Object123" ValidationGroup="A">*</asp:CompareValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    Re-Enter Password</td>
                <td class="style5">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" 
                        ValidationGroup="A"></asp:TextBox>
                </td>
                <td class="style4">
                    <asp:CompareValidator ID="CompareValidator2" runat="server" 
                        ControlToCompare="TextBox2" ControlToValidate="TextBox3" 
                        ErrorMessage="Password Mismatch" ForeColor="Red" ValidationGroup="A">*</asp:CompareValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    Enter Age</td>
                <td class="style5">
                    <asp:TextBox ID="TextBox4" runat="server" ValidationGroup="B"></asp:TextBox>
                </td>
                <td class="style4">
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ControlToValidate="TextBox4" ErrorMessage="Age must be between 18 and 60" 
                        ForeColor="Red" MaximumValue="60" MinimumValue="18" Type="Integer" 
                        ValidationGroup="B">*</asp:RangeValidator>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="TextBox4" ErrorMessage="Please enter age" 
                        ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Enter E-Mail</td>
                <td class="style5">
                    <asp:TextBox ID="TextBox5" runat="server" ValidationGroup="B"></asp:TextBox>
                </td>
                <td class="style4">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="TextBox5" ErrorMessage="Invalid EMail ID" ForeColor="Red" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        ValidationGroup="B">*</asp:RegularExpressionValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    Enter Name</td>
                <td class="style5">
                    <asp:TextBox ID="TextBox6" runat="server" ValidationGroup="B"></asp:TextBox>
                </td>
                <td class="style4">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                        ControlToValidate="TextBox6" ErrorMessage="Invalid Format" ForeColor="Red" 
                        ValidationExpression="([A-Z]|[0-9]){5}" ValidationGroup="B">*</asp:RegularExpressionValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    Enter Number</td>
                <td class="style5">
                    <asp:TextBox ID="TextBox7" runat="server" ValidationGroup="B"></asp:TextBox>
                </td>
                <td class="style4">
                    <asp:CustomValidator ID="CustomValidator1" runat="server" 
                        ControlToValidate="TextBox7" ErrorMessage="Number must be even and &gt; 20" 
                        ForeColor="Red" onservervalidate="CustomValidator1_ServerValidate" 
                        ClientValidationFunction="CheckEvenOdd" ValidationGroup="B">*</asp:CustomValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Button ID="Button1" runat="server" Text="Submit1" ValidationGroup="A" />
                </td>
                <td class="style5">
                    <asp:Button ID="Button2" runat="server" Text="Submit2" ValidationGroup="B" />
                </td>
                <td class="style4">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ValidationGroup="A" />
                </td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
                        ValidationGroup="B" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
