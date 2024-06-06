<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 448px;
            width: 1493px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
        </div>
    &nbsp;&nbsp;
        <asp:Label ID="lblOrderId" runat="server" Text="Order ID"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderId" runat="server" Height="16px" OnTextChanged="TextBox1_TextChanged1" style="margin-bottom: 0px" Width="121px"></asp:TextBox>
        <br />
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 258px; top: 33px; position: absolute" Text="Find" OnClick="btnFind_Click" />
        <br />
        <asp:Label ID="lblShoeId" runat="server" Text="Shoe ID"></asp:Label>
        <asp:TextBox ID="txtShoeId" runat="server" style="z-index: 1; left: 77px; top: 69px; position: absolute"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 96px; top: 117px; position: absolute; height: 22px; width: 128px" OnTextChanged="TxtCustomerId_TextChanged"></asp:TextBox>
        <br />
        <br />
        
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 9px; top: 120px; position: absolute; height: 24px" Text="Customer ID"></asp:Label>
        
        <br />
        <asp:TextBox ID="txtTotalAmount" runat="server" style="z-index: 1; left: 111px; top: 289px; position: absolute; height: 21px; width: 110px;"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 16px; top: 165px; position: absolute" Text="Staff ID"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 80px; top: 166px; position: absolute; margin-bottom: 0px" OnTextChanged="txtStaffId_TextChanged"></asp:TextBox>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 18px; top: 204px; position: absolute; height: 28px" Text="Order Date"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 105px; top: 203px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblNote" runat="server" style="z-index: 1; left: 20px; top: 251px; position: absolute" Text="Note of Order"></asp:Label>
        <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 21px; top: 291px; position: absolute" Text="Total Amount"></asp:Label>
        <asp:Label ID="lblOrderStatus" runat="server" style="z-index: 1; left: 23px; top: 347px; position: absolute; bottom: 207px; width: 85px;" Text="Order Status:"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 139px; top: 520px; position: absolute" Text="Cancel" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnOk" runat="server" Style="z-index: 1; left: 17px; top: 519px; position: absolute; width: 65px;" Text="OK" OnClick="btnOk_Click" />
            <asp:TextBox ID="txtNote" runat="server" style="z-index: 1; left: 118px; top: 250px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 482px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtOrderStatus" runat="server" style="z-index: 1; left: 14px; top: 374px; position: absolute; right: 713px; height: 29px;"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 15px; top: 422px; position: absolute" Text="Active" />
        <asp:Label ID="lblOrderStatus1" runat="server" style="z-index: 1; left: 111px; top: 348px; position: absolute" Text="(Pending/Dispatch/Cancel)"></asp:Label>
    </form>
</body>
</html>
