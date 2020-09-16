<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="BookABike.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function msgPromptEmail() {
            var email = prompt("Enter email...");
            var pass = prompt("Enter password...");
            document.getElementById('HiddenField1').value = email;
            document.getElementById('HiddenField2').value = pass;
            document.getElementById('btnCheck').click();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField ID="HiddenField1" runat="server" value=""/>
        <asp:HiddenField ID="HiddenField2" runat="server" value=""/>
        <div style="border: thick groove #FF0000; height: 94px; background-color: #CCCCCC;">
        <style type="text/css">.inlineBlock { display: inline-block; }</style>
        <style type="text/css">.floatRight { float: left; }</style>
        <style type="text/css">.floatRight { float: right; }</style>
            &nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Forte" Font-Size="XX-Large" Text="Book a Bike"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            
            <asp:Label ID="Label3" runat="server" Text="Client Email: "></asp:Label> &nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="162px" ></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Password: "></asp:Label> &nbsp;<asp:TextBox ID="TextBox3" runat="server" Height="16px" Width="162px" TextMode="Password" ></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Login" Width="119px" OnClick ="Button1_Click" />
			&nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            &nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Forte" Font-Size="XX-Large" Text="Potchefstroom"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ResetPassword.aspx" Visible="False">Forgot Password ?</asp:HyperLink>

             &nbsp;&nbsp;

             <asp:UpdatePanel ID="up1" runat="server" >
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
        </Triggers>

        <ContentTemplate> &nbsp;&nbsp;<asp:AdRotator ID="AdRotator1" CssClass ="floatLeft" runat="server" AdvertisementFile="~/PicData.xml" Height="800px" Width="1500px" BorderStyle="None" OnAdCreated="AdRotator1_AdCreated"/> &nbsp;&nbsp;
            </div>

            <br />
            <br />

        </ContentTemplate>
    </asp:UpdatePanel> 
  
            <dir>
                <li style="height: 326px">
            <asp:Label ID="Label5" runat="server" Text="Book a Bike Potchefstroom consists of over fifty" Font-Bold="True" Font-Names="Agency FB" Font-Overline="False" Font-Size="X-Large" ForeColor="#FF6600"></asp:Label>
             
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
                    
            <asp:Button ID="Button2" runat="server" Text="Register" Height="46px" Width="191px" BackColor="Black" ForeColor="#FF6600" OnClick="Button2_Click"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="About" Height="46px" Width="191px" BackColor="Black" ForeColor="#FF6600" OnClick="Button3_Click"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Contact Us" Height="46px" Width="191px" BackColor="Black" ForeColor="#FF6600" OnClick="Button4_Click"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" Text="Bike Stations" Height="46px" Width="191px" BackColor="Black" ForeColor="#FF6600" OnClick="Button5_Click" />
                    <br />
                     &nbsp;&nbsp; &nbsp;
             <asp:Label ID="Label6" runat="server" Text=" bike stations situated in and around Potchefstroom." Font-Bold="True" Font-Names="Agency FB" Font-Overline="False" Font-Size="X-Large" ForeColor="#FF6600"></asp:Label>
              <br />
                    <br />
                     &nbsp;&nbsp; &nbsp;
             <asp:Label ID="Label7" runat="server" Text="       FOR MORE INFO: Click on 'ABOUT'" Font-Bold="True" Font-Names="Agency FB" Font-Overline="False" Font-Size="X-Large" ForeColor="#FF6600"></asp:Label>
                    <br />
                    <br />
                    <asp:Image ID="Image1" runat="server"  Height="339px" ImageUrl="~/Images/HIW_burned.png" Width="438px" BorderStyle="None" />
            <br />
               
                </li>
  
            <br />
            <br />
        </div>

        <div style="float: left; width: 60px">
  
            <asp:Timer ID="Timer1" runat="server" Interval="5000" OnTick="Timer1_Tick">
            </asp:Timer>

        </div>
  
  <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
      
        
        <asp:RadioButton ID="rdbAdmin" runat="server" Text="Admin" GroupName="AdminCheck" OnCheckedChanged="Admin_CheckedChanged" Font-Bold="True" Font-Size="13pt" AutoPostBack="True" />
        <br />
        <asp:RadioButton ID="rdbStaff" runat="server" Text="Staff" GroupName="AdminCheck" OnCheckedChanged="Admin_CheckedChanged" Font-Bold="True" Font-Size="13pt" />
        <br />
        <input id="test1" type="button" value="Login" onclick="msgPromptEmail()" />

        <br />
        <asp:Label ID="Label8" runat="server" Text="Copyright 2019 - Designed for Google Chrome" Font-Bold="True" Font-Size="Medium"></asp:Label>
                 
        <asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" Visible="True" Enabled="True" Height="16px" Width="16px" />

    </form>
</body>
</html>
