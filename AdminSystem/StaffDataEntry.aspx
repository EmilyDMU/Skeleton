<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 10px; top: 51px; position: absolute" Text="Staff ID" width="174px"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 202px; top: 51px; position: absolute" height="38px" width="248px"></asp:TextBox>
            <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 10px; top: 125px; position: absolute" Text="Name" width="174px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 202px; top: 129px; position: absolute" height="38px" width="248px"></asp:TextBox>
        </p>
        <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 6px; top: 209px; position: absolute" Text="Date Of Birth"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 202px; top: 211px; position: absolute" height="38px" width="248px"></asp:TextBox>
            <asp:Label ID="lblStaffRole" runat="server" style="z-index: 1; left: 10px; top: 290px; position: absolute" Text="Role" width="174px"></asp:Label>
            <asp:TextBox ID="txtStaffRole" runat="server" style="z-index: 1; left: 202px; top: 292px; position: absolute" height="38px" width="248px"></asp:TextBox>
        </p>
        <asp:Label ID="lblStaffStatus" runat="server" style="z-index: 1; left: 10px; top: 444px; position: absolute" Text="Status" width="174px"></asp:Label>
        <p>
            <asp:Label ID="lblStaffDepartment" runat="server" style="z-index: 1; left: 8px; top: 372px; position: absolute" Text="Department" width="174px"></asp:Label>
            <asp:TextBox ID="txtStaffDepartment" runat="server" style="z-index: 1; left: 202px; top: 376px; position: absolute" height="38px" width="248px"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtStaffStatus" runat="server" style="z-index: 1; left: 202px; top: 450px; position: absolute" height="38px" width="248px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkStaffPermission" runat="server" style="z-index: 1; left: 306px; top: 552px; position: absolute; bottom: 470px" Text="Permission" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 666px; position: absolute"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 112px; top: 611px; position: absolute; width: 129px;" Text="OK" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 252px; top: 611px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
