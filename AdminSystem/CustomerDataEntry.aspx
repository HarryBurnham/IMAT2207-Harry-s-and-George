<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitleCA" runat="server" style="z-index: 1; left: 244px; top: 107px; position: absolute; width: 219px" Text="Harry's and George LTD"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p style="height: 637px">
            <asp:Label ID="lblCustomerID" runat="server" height="25px" style="z-index: 1; left: 74px; top: 149px; position: absolute; width: 89px" Text="CustomerID"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 381px; top: 655px; position: absolute; width: 46px; margin-top: 0px" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 440px; top: 654px; position: absolute" Text="Cancel" />
            <asp:CheckBox ID="chkAccount" runat="server" style="z-index: 1; left: 187px; top: 603px; position: absolute" Text="Account" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 84px; top: 641px; position: absolute"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 194px; top: 272px; position: absolute; height: 107px; width: 330px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 74px; top: 550px; position: absolute; height: 25px; width: 111px" Text="Password"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblAddress" runat="server" style="z-index: 1; top: 267px; position: absolute; width: 111px; height: 25px; left: 74px" Text="Address"></asp:Label>
        <asp:Label ID="lblFirstname" runat="server" style="z-index: 1; left: 74px; top: 149px; position: absolute; width: 87px; height: 25px; margin-top: 48px;" Text="First name"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 192px; top: 145px; position: absolute; width: 330px"></asp:TextBox>
        </p>
        <asp:Label ID="lblSurname" runat="server" style="z-index: 1; left: 74px; top: 233px; position: absolute; height: 25px; width: 111px" Text="Surname"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 550px; top: 144px; position: absolute" Text="Find" />
        <asp:TextBox ID="txtFirstname" runat="server" style="z-index: 1; left: 192px; top: 187px; position: absolute; width: 330px" height="25px"></asp:TextBox>
        <asp:TextBox ID="txtSurname" runat="server" style="z-index: 1; left: 192px; top: 222px; position: absolute; width: 330px" height="25px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 74px; top: 405px; position: absolute; width: 111px" Text="Phone number" height="25px"></asp:Label>
        <p>
            <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 192px; top: 402px; position: absolute; width: 330px" height="25px"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtEmailAddress" runat="server" style="z-index: 1; left: 192px; top: 443px; position: absolute; width: 330px" height="25px"></asp:TextBox>
        <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 74px; top: 499px; position: absolute; width: 111px" Text="Date Of Birth" height="25px"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 192px; top: 492px; position: absolute; width: 330px" height="25px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 192px; top: 548px; position: absolute; width: 330px" height="25px"></asp:TextBox>
        <asp:Label ID="lblEmailAddress" runat="server" style="z-index: 1; left: 74px; top: 443px; position: absolute; height: 40px; margin-bottom: 12px;" Text="Email Address" width="111px"></asp:Label>
        <p>
            &nbsp;</p>
    </form>

</body>
</html>
