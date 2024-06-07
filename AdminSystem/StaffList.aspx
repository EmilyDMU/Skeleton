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
        <asp:Button ID="lblEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 144px; top: 597px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 32px; top: 975px; position: absolute"></asp:Label>
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 272px; top: 805px; position: absolute" Text="Clear Filter" />
            <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 24px; top: 19px; position: absolute; height: 524px; width: 553px"></asp:ListBox>
        <asp:Label ID="lblReportDep" runat="server" style="z-index: 1; left: 20px; top: 711px; position: absolute" Text="Enter a Department"></asp:Label>
        <asp:TextBox ID="txtReportDep" runat="server" style="z-index: 1; left: 324px; top: 707px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 40px; top: 807px; position: absolute" Text="Apply Filter" />
    </form>
</body>
</html>
