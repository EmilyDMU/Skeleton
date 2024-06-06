<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 345px">
            <asp:TextBox ID="txtSupplierId" runat="server" style="z-index: 1; left: 123px; top: 33px; position: absolute"></asp:TextBox>
            <asp:Label ID="tblSupplierName" runat="server" style="z-index: 1; left: 32px; top: 72px; position: absolute" Text="Supplier Name" width="70px"></asp:Label>
            <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 123px; top: 70px; position: absolute"></asp:TextBox>
            <asp:Label ID="tblPhoneNum" runat="server" style="z-index: 1; left: 32px; top: 110px; position: absolute" Text="Phone Number" width="70px"></asp:Label>
            <asp:Label ID="tblPostCode" runat="server" style="z-index: 1; left: 32px; top: 153px; position: absolute" Text="Post Code" width="70px"></asp:Label>
            <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 123px; top: 149px; position: absolute"></asp:TextBox>
            <asp:Label ID="tblStreetNum" runat="server" style="z-index: 1; left: 32px; top: 194px; position: absolute" Text="Street No" width="70px"></asp:Label>
            <asp:TextBox ID="txtStreetNum" runat="server" style="z-index: 1; left: 123px; top: 189px; position: absolute"></asp:TextBox>
            <asp:Label ID="tblStreet" runat="server" style="z-index: 1; left: 32px; top: 225px; position: absolute" Text="Street" width="70px"></asp:Label>
            <asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 123px; top: 222px; position: absolute"></asp:TextBox>
            <asp:Label ID="tblRegistrationDate" runat="server" style="z-index: 1; left: 32px; top: 262px; position: absolute" Text="Registration Date" width="70px"></asp:Label>
            <asp:TextBox ID="txtRegistrationDate" runat="server" style="z-index: 1; left: 123px; top: 258px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 32px; top: 313px; position: absolute; bottom: 321px" width="70px"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 32px; top: 368px; position: absolute" Text="OK" width="70px" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 159px; top: 368px; position: absolute" Text="Cancel" />
        </div>
        <asp:TextBox ID="txtPhoneNum" runat="server" style="z-index: 1; left: 123px; top: 106px; position: absolute"></asp:TextBox>
        <asp:Label ID="tblSupplierId" runat="server" style="z-index: 1; left: 32px; top: 34px; position: absolute" Text="Supplier ID"></asp:Label>
    </form>
</body>
</html>

