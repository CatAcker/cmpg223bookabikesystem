<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="BookABike.About" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/Images/About.png" Height="1008px">
                <asp:Panel ID="Panel2" runat="server" BackColor="#FF9900" Height="45px">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Main.aspx">Return to Main Page</asp:HyperLink>
                </asp:Panel>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
