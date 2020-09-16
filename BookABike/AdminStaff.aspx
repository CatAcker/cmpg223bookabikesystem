<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminStaff.aspx.cs" Inherits="BookABike.AdminStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="SS1.css" />
    <style type="text/css">
        .auto-style2 {
            width: 232px;
        }
    </style>
</head>
<body style="height: 719px; background-color: #CCCCCC;">
    <form id="form1" runat="server">
        <div style="border: thick outset #FF0000; background-color: #CCCCCC">
            <asp:Button ID="btnAddStaff" runat="server" Text="Add New Staff" Height="46px" Width="191px" CssClass="button" BackColor="Black" ForeColor="#FF6600" CausesValidation="False" OnClick="btnAddStaff_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnRemoveStaff" runat="server" Text="Remove Staff Member" Height="46px" Width="191px" CssClass="button" BackColor="Black" ForeColor="#FF6600" CausesValidation="False" OnClick="btnRemoveStaff_Click" />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCalcProfit" runat="server" Text="Calculate Profit This Month" Height="46px" Width="216px" CssClass="button" BackColor="Black" ForeColor="#FF6600" CausesValidation="False" OnClick="btnCalcProfit_Click" />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAddBike" runat="server" Text="Add New Bike" Height="46px" Width="191px" CssClass="button" BackColor="Black" ForeColor="#FF6600" CausesValidation="False" OnClick="btnAddBike_Click" />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnRemoveBike" runat="server" Text="Remove Bike" Height="46px" Width="191px" CssClass="button" BackColor="Black" ForeColor="#FF6600" CausesValidation="False" OnClick="btnRemoveBike_Click" />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnChangeBikeLoc" runat="server" Text="Change Bike Location" Height="46px" Width="191px" CssClass="button" BackColor="Black" ForeColor="#FF6600" CausesValidation="False" OnClick="btnChangeBikeLoc_Click" />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAddCl" runat="server" Text="Add New Client" Height="46px" Width="191px" CssClass="button" BackColor="Black" ForeColor="#FF6600" CausesValidation="False" OnClick="btnAddCl_Click" />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnRemoveCl" runat="server" Text="Remove Client" Height="46px" Width="191px" CssClass="button" BackColor="Black" ForeColor="#FF6600" CausesValidation="False" OnClick="btnRemoveCl_Click" />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;            
       </div>         
        <asp:MultiView ID="multiViewChange" runat="server">
            <asp:View ID="viewAddStaff" runat="server">
                <asp:CheckBox ID="chkAdmin" runat="server" Text="Is a new admin" AutoPostBack="True" OnCheckedChanged="chkAdmin_CheckedChanged" />
                &nbsp;<table style="width:100%;">
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Forte" Font-Size="Large" Text="Staff's FirstName:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtStaffFN" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Forte" Font-Size="Large" Text="Staff's Lastname:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtStaffLN" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Forte" Font-Size="Large" Text="Staff's Weekly Salary:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Names="Forte" Font-Size="Large" Text="Staff's Email:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtStaffEmail" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Names="Forte" Font-Size="Large" Text="Staff's Contact Number:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtStaffConNumber" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Names="Forte" Font-Size="Large" Text="Staff's Password:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtStaffPass" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Forte" Font-Size="Large" Text="Staff's Stations:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtNewStStation" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnAddNewStaff" runat="server" BackColor="Black" CausesValidation="False" CssClass="button" ForeColor="#FF6600" Height="46px" Text="Add New Staff" Width="191px" OnClick="btnAddNewStaff_Click" />
                            <asp:Label ID="lblPass1" runat="server" Text="..."></asp:Label>
                        </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="viewRmStaff" runat="server">
            </asp:View>
            <asp:View ID="viewCalcProfit" runat="server">
            </asp:View>
            <asp:View ID="viewAddBike" runat="server">
            </asp:View>
            <asp:View ID="viewRmBike" runat="server">
            </asp:View>
            <asp:View ID="viewChangeBikeLoc" runat="server">
            </asp:View>
            <asp:View ID="viewNewCl" runat="server">
            </asp:View>
            <asp:View ID="viewRmCl" runat="server">
            </asp:View>
        </asp:MultiView>
    </form>
</body>
</html>
