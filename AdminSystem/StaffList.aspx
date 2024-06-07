<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 356px; top: 593px; position: absolute" Text="Delete" />
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 24px; top: 597px; position: absolute" Text="Add" />
        <asp:Button ID="lblEdit" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 144px; top: 597px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 38px; top: 693px; position: absolute"></asp:Label>
    </form>
</body>
</html>
