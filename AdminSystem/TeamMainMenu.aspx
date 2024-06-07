<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="MainMenuTitle" runat="server" style="z-index: 1; left: 441px; top: 158px; position: absolute" Text="ShoeZone Main Menu"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnOrder" runat="server" style="z-index: 1; left: 54px; top: 282px; position: absolute; height: 67px; width: 211px" Text="Order Processing" OnClick="btnOrder_Click" />
        <asp:Button ID="btnStaff" runat="server" style="z-index: 1; left: 353px; top: 305px; position: absolute" Text="Staff" OnClick="btnStaff_Click" />
    </form>
</body>
</html>
