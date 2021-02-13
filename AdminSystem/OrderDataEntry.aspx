<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        &nbsp;<div>
            <asp:Label ID="lblOrderId" runat="server" Text="Order ID" width="90px"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" width="90px"></asp:Label>
&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCost" runat="server" Text="Cost" width="90px"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderType" runat="server" Text="Order Type" width="90px"></asp:Label>
&nbsp; <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID" width="90px"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;<asp:CheckBox ID="lblDispatched" runat="server" Text="Dispatched" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
