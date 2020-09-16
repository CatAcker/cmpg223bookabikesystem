<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="BookABike.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="SS1.css" />
    <style type="text/css">
        .auto-style1 {
            background-color: #00CC00;
        }
        .auto-style2 {
            background-color: #CC0000;
        }
    </style>
</head>
<body style="height: 719px; background-color: #CCCCCC;">
    <form id="form1" runat="server">
        <div style="border: thick outset #FF0000; background-color: #CCCCCC">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Britannic Bold" Font-Size="XX-Large" Text="DASHBOARD - SESSION USER:"></asp:Label>
        &nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Britannic Bold" Font-Size="XX-Large"></asp:Label>
            <br />
            <br />

            <asp:Button ID="Button1" runat="server" CssClass="button" Text="Book a Bike" Height="46px" Width="191px" BackColor="Black" ForeColor="#FF6600" OnClick="Button1_Click" CausesValidation="False" />
    
            &nbsp;<asp:Panel ID="Panel1" runat="server" Height="782px" Visible="False" BackColor="#CCCCCC" CssClass="auto-style3" BackImageUrl="~/Images/Checkout&amp;Return2.jpg">
                <br />
                <asp:Label ID="Label3" runat="server" Text="Checkout:" Font-Bold="True" Font-Underline="True" CssClass="auto-style1" BackColor="#23B14D"></asp:Label>
                &nbsp;
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Time:  " CssClass="auto-style1" BackColor="#23B14D"></asp:Label>&nbsp;&nbsp;
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server" Height="21px" Width="134px" CssClass="auto-style1" BackColor="#23B14D">


                    

                    <asp:ListItem Value="04:00"></asp:ListItem>
                    <asp:ListItem Value="05:00"></asp:ListItem>
                    <asp:ListItem Value="06:00"></asp:ListItem>
                    <asp:ListItem Value="07:00"></asp:ListItem>
                    <asp:ListItem Value="08:00"></asp:ListItem>
                    <asp:ListItem Value="09:00"></asp:ListItem>
                    <asp:ListItem Value="10:00"></asp:ListItem>
                    <asp:ListItem Value="11:00"></asp:ListItem>
                    <asp:ListItem Value="12:00"></asp:ListItem>
                    <asp:ListItem Value="13:00"></asp:ListItem>
                    <asp:ListItem Value="14:00"></asp:ListItem>
                    <asp:ListItem Value="15:00"></asp:ListItem>
                    <asp:ListItem Value="16:00"></asp:ListItem>
                    <asp:ListItem Value="17:00"></asp:ListItem>
                    <asp:ListItem Value="18:00"></asp:ListItem>
                    <asp:ListItem Value="19:00"></asp:ListItem>
                    <asp:ListItem Value="20:00"></asp:ListItem>
                    <asp:ListItem Value="21:00"></asp:ListItem>
                    <asp:ListItem Value="22:00"></asp:ListItem>




                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="Date:  " BackColor="#23B14D"></asp:Label>&nbsp;&nbsp;
                &nbsp;<asp:Calendar ID="Calendar1" runat="server" Height="142px" Width="223px" CssClass="auto-style1" BackColor="#23B14D">
                    <TitleStyle BackColor="#23B14D" BorderStyle="Outset" />
                </asp:Calendar>
                &nbsp;<br />&nbsp;<asp:Label ID="Label6" runat="server" BackColor="#ED1B24" CssClass="auto-style2" Font-Bold="True" Font-Underline="True" Text="Return:"></asp:Label>
&nbsp;
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" BackColor="#ED1B24" CssClass="auto-style2" Text="Time:  "></asp:Label>
                &nbsp;&nbsp;
                <br />
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="auto-style2" Height="21px" Width="134px" BackColor="#ED1B24">

                    <asp:ListItem Value="04:00"></asp:ListItem>
                    <asp:ListItem Value="05:00"></asp:ListItem>
                    <asp:ListItem Value="06:00"></asp:ListItem>
                    <asp:ListItem Value="07:00"></asp:ListItem>
                    <asp:ListItem Value="08:00"></asp:ListItem>
                    <asp:ListItem Value="09:00"></asp:ListItem>
                    <asp:ListItem Value="10:00"></asp:ListItem>
                    <asp:ListItem Value="11:00"></asp:ListItem>
                    <asp:ListItem Value="12:00"></asp:ListItem>
                    <asp:ListItem Value="13:00"></asp:ListItem>
                    <asp:ListItem Value="14:00"></asp:ListItem>
                    <asp:ListItem Value="15:00"></asp:ListItem>
                    <asp:ListItem Value="16:00"></asp:ListItem>
                    <asp:ListItem Value="17:00"></asp:ListItem>
                    <asp:ListItem Value="18:00"></asp:ListItem>
                    <asp:ListItem Value="19:00"></asp:ListItem>
                    <asp:ListItem Value="20:00"></asp:ListItem>
                    <asp:ListItem Value="21:00"></asp:ListItem>
                    <asp:ListItem Value="22:00"></asp:ListItem>


                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label8" runat="server" CssClass="auto-style2" Text="Date:  "></asp:Label>
                &nbsp;&nbsp; &nbsp;<asp:Calendar ID="Calendar2" runat="server" CssClass="auto-style2" Height="142px" Width="223px" BackColor="#ED1B24" BorderColor="#ED1B24">
                    <TitleStyle BorderColor="#ED1B24" BorderStyle="Outset" />
                </asp:Calendar>
                <br />
                &nbsp; Note: Late returns will result in a fine!<br />
                <br />
                &nbsp;
                <asp:Button ID="Button7" runat="server" Height="46px" OnClick="Button7_Click" Text="Book My Bike!" Width="182px" CausesValidation="False" />
            </asp:Panel>

            <br />
                        <asp:Button ID="Button3" runat="server" Text="Bookings" Height="46px" Width="191px" CssClass="button" BackColor="Black" ForeColor="#FF6600" OnClick="Button3_Click" CausesValidation="False" />
            &nbsp;<asp:Panel ID="Panel2" runat="server" Height="325px" Visible="False" Width="1070px" BackImageUrl="~/Images/bookings.png">
                <asp:Label ID="Label9" runat="server" Text="Amount Due: R"></asp:Label>
                <asp:Label ID="Label10" runat="server" Text="0.00"></asp:Label>
                <br />
                <br />
                List of Outstanding Payments:<br />
                <asp:ListBox ID="ListBox1" runat="server" Height="165px" Width="371px"></asp:ListBox>
                <br />
                <br />
                <asp:Button ID="Button8" runat="server" Height="52px" OnClick="Button8_Click" Text="Pay now" Width="170px" CausesValidation="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button15" runat="server" CausesValidation="False" Height="52px" OnClick="Button15_Click" Text="View all Bookings" Width="170px" />
            </asp:Panel>
            <br />
                        <asp:Button ID="Button4" runat="server" Text="Bike Stations" Height="46px" Width="191px" CssClass="button" BackColor="Black" ForeColor="#FF6600" OnClick="Button4_Click" CausesValidation="False" />
            &nbsp;<asp:Panel ID="Panel3" runat="server" Height="552px" Visible="False" Width="1446px" style="margin-right: 0px" BorderStyle="Outset">
                Bike Stations are indicated on the map with a blue dot:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label11" runat="server" Text="Coordinates: " Font-Bold="True"></asp:Label>
                <asp:Label ID="Label12" runat="server" Text="-" Font-Bold="True"></asp:Label>
                <br />
                <td colspan="4">
                    <asp:ImageMap ID="india" runat="server" BackColor="#C0C000" BorderColor="DarkSlateGray" ForeColor="Red" Height="500px" HotSpotMode="PostBack" ImageUrl="~/Images/BikeStations.jpg" OnClick="india_Click" Width="887px">
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="1" Radius="7" X="440" Y="7" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="2" Radius="7" X="490" Y="13" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="3" Radius="7" X="472" Y="21" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="4" Radius="7" X="616" Y="30" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="5" Radius="7" X="617" Y="99" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="6" Radius="7" X="649" Y="199" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="7" Radius="7" X="715" Y="245" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="8" Radius="7" X="721" Y="373" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="9" Radius="7" X="666" Y="385" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="10" Radius="7" X="481" Y="40" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="11" Radius="7" X="459" Y="48" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="12" Radius="7" X="459" Y="73" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="13" Radius="7" X="457" Y="101" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="14" Radius="7" X="442" Y="112" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="15" Radius="7" X="473" Y="70" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="16" Radius="7" X="482" Y="104" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="17" Radius="7" X="506" Y="53" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="18" Radius="7" X="574" Y="241" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="19" Radius="7" X="326" Y="438" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="20" Radius="7" X="201" Y="439" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="21" Radius="7" X="490" Y="475" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="22" Radius="7" X="530" Y="412" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="23" Radius="7" X="492" Y="368" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="24" Radius="7" X="535" Y="342" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="25" Radius="7" X="520" Y="296" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="26" Radius="7" X="425" Y="292" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="27" Radius="7" X="385" Y="370" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="28" Radius="7" X="452" Y="244" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="29" Radius="7" X="420" Y="210" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="30" Radius="7" X="458" Y="190" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="31" Radius="7" X="460" Y="135" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="32" Radius="7" X="440" Y="155" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="33" Radius="7" X="500" Y="165" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="34" Radius="7" X="370" Y="162" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="35" Radius="7" X="368" Y="254" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="36" Radius="7" X="264" Y="250" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="37" Radius="7" X="275" Y="142" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="38" Radius="7" X="320" Y="142" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="39" Radius="7" X="330" Y="232" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="40" Radius="7" X="345" Y="278" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="41" Radius="7" X="302" Y="310" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="42" Radius="7" X="234" Y="190" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="43" Radius="7" X="480" Y="140" />
                        <asp:CircleHotSpot HotSpotMode="PostBack" NavigateUrl="~/map.aspx" PostBackValue="44" Radius="7" X="400" Y="140" />



                    </asp:ImageMap>
                    <asp:Image ID="Image1" runat="server" Height="237px" style="margin-top: 0px" Visible="False" Width="547px" ImageUrl="~/Images/l1.jpg" />
                </td>
                        

                    
                <style type="text/css">.inlineBlock { display: inline-block; }</style>
        <style type="text/css">.floatRight { float: left; }</style>
        <style type="text/css">.floatRight { float: right; }</style>

                        

                    

            </asp:Panel>
            <br />
                        <asp:Button ID="Button5" runat="server" Text="Update Account" Height="46px" Width="191px" CssClass="button" BackColor="Black" ForeColor="#FF6600" OnClick="Button5_Click" />
            &nbsp;<asp:Panel ID="Panel4" runat="server" Height="102px" BorderStyle="Dotted" Visible="False" Width="471px">
                <br />
                 &nbsp;<asp:Button ID="Button9" runat="server" BackColor="#FF9900" CausesValidation="True" Height="52px" OnClick="Button9_Click" Text="Change Email" Width="220px" />
&nbsp;&nbsp;<asp:Button ID="Button11" runat="server" BackColor="#FF9900" CausesValidation="False" Height="52px" OnClick="Button11_Click" Text="Change Password" Width="220px" />
&nbsp;
                <br />
                <br />
            </asp:Panel>
            <asp:Panel ID="Panel7" runat="server" Height="184px" BorderStyle="Dotted" Visible="False" Width="472px">
                &nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label13" runat="server" Text="Email Address:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Width="263px"></asp:TextBox>
                &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Invalid Email Address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="b" ForeColor="Red"></asp:RegularExpressionValidator>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label14" runat="server" Text="Password:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="263px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Password is Required" ControlToValidate="TextBox2" ValidationGroup="b" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Button ID="Button13" runat="server" BackColor="Black" BorderColor="#FF9900" ForeColor="#FF9900" Height="47px" Text="Update Email" Width="472px" ValidationGroup="b" OnClick="Button13_Click"  />
            </asp:Panel>
            <asp:Panel ID="Panel8" runat="server" BorderStyle="Dotted" Height="260px" Visible="False" Width="559px">
                &nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label15" runat="server" Text="Current Password:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server" Width="263px" TextMode="Password"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Current Password is Required" ValidationGroup="a" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label16" runat="server" Text="New Password:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" Width="263px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="New Password is Required" ControlToValidate="TextBox3" ValidationGroup="a" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label17" runat="server" Text="Confirm New Password:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" Width="263px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox5" ErrorMessage="Confirm New Password is Required" ValidationGroup="a" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button14" runat="server" BackColor="Black" BorderColor="#FF9900" ForeColor="#FF9900" Height="47px" Text="Update Password" Width="559px" ValidationGroup="a" OnClick="Button14_Click" />
            </asp:Panel>
            <br />
                        <asp:Button ID="Button6" runat="server" Text="Payment Details" CssClass="button" Height="46px" Width="191px" BackColor="Black" ForeColor="#FF6600" OnClick="Button6_Click" CausesValidation="False" />
            &nbsp;<asp:Panel ID="Panel5" runat="server" Height="329px" Visible="False">
                <br />
                &nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton1" runat="server" Height="79px" ImageUrl="~/Images/PayPalLogo.png" OnClick="ImageButton1_Click" Width="223px" />
                <br />
                <br />
                &nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton2" runat="server" Height="79px" ImageUrl="~/Images/Mastercard-PNG-File.png" OnClick="ImageButton2_Click" Width="223px" />
                <br />
                <br />
                &nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton3" runat="server" Height="79px" ImageUrl="~/Images/American-Express-Symbol.jpg" OnClick="ImageButton3_Click" Width="223px" />
            </asp:Panel>
            <br />

            <br />
            <asp:Button ID="Button2" runat="server" Text="Log Out" Height="46px" Width="191px" BackColor="Black" CssClass="button" ForeColor="#FF6600" OnClick="Button2_Click" CausesValidation="False" />
            &nbsp;<br />

        </div>
    </form>
</body>
</html>
