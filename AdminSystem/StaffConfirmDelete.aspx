﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 400px; top: 417px; position: absolute" Text="No" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 94px; top: 420px; position: absolute" Text="Yes" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 180px; position: absolute" Text="Are you sure you want to delete this record"></asp:Label>
    </form>
</body>
</html>
