<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Registration.aspx.vb" Inherits="Exp3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 81%;
            background-color: #C0C0C0;
        }
        .auto-style2 {
            width: 174px;
        }
        .auto-style3 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>Registration Form<table class="auto-style1">
                <tr>
                    <td class="auto-style2">Username</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtUser" runat="server" Width="174px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUser" ErrorMessage="Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtUser" Display="Dynamic" ErrorMessage="Atleast 5 characters" ForeColor="Blue" ValidateEmptyText="True">*</asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Age</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtAge" runat="server" Width="176px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAge" ErrorMessage="Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="Age must be from 18 to 50" ForeColor="Blue" MaximumValue="50" MinimumValue="18" Type="Integer">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtP1" runat="server" TextMode="Password" Width="174px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtP1" ErrorMessage="Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Confirm Password</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtP2" runat="server" TextMode="Password" Width="176px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtP2" ErrorMessage="Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtP1" ControlToValidate="txtP2" Display="Dynamic" ErrorMessage="Password does not match" ForeColor="Blue">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Email</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtEmail" runat="server" Width="173px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEmail" ErrorMessage="Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Invalid Email " ForeColor="Blue" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                </table>
                <asp:Button ID="btnS" runat="server" Text="Submit" Width="56px" />
                <br />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            </center>
        </div>
    </form>
</body>
</html>
