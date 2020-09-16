<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BikeStations.aspx.cs" Inherits="BookABike.BikeStations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/Images/7039786-new-york-city-desktop-wallpaper-widescreen.jpg" Height="1076px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Names="Berlin Sans FB" Font-Size="64pt" Font-Underline="False" ForeColor="White" Text="BIKE STATIONS"></asp:Label>
                <br />
                <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="34pt" ForeColor="White" Text="Coordinates: "></asp:Label>
                <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="34pt" ForeColor="White" Text="-"></asp:Label>
                <br />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageMap ID="india" runat="server" BackColor="#C0C000" BorderColor="DarkSlateGray" ForeColor="Red" Height="500px" HotSpotMode="PostBack" ImageAlign="Left
                    " ImageUrl="~/Images/BikeStations.jpg" OnClick="india_Click" Width="887px">
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
                
                <asp:Image ID="Image1" runat="server" Height="301px" ImageAlign="AbsMiddle" ImageUrl="~/Images/l1.jpg" style="margin-top: 0px" Visible="False" Width="591px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Return To Main Page" BackColor="#3333FF" Font-Bold="True" Font-Names="Algerian" Font-Size="12pt" ForeColor="White" Height="69px" OnClick="Button1_Click" Width="256px" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
