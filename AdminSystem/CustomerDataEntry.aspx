<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        &nbsp;<form id="form1" runat="server">
        <div>
        </div>
            <div>
            </div>
            <p>
                <asp:Label ID="lblTitleLog" runat="server" style="z-index: 1; left: 365px; top: 56px; position: absolute; width: 209px" Text="Harry's and George LTD"></asp:Label>
            </p>
            <p>
                <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 97px; top: 139px; position: absolute; right: 1196px; height: 3px" Text="Username:"></asp:Label>
            </p>
            <p>
                <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 207px; top: 138px; position: absolute; width: 459px"></asp:TextBox>
                <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 98px; top: 195px; position: absolute; right: 1193px" Text="Password:"></asp:Label>
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 206px; top: 191px; position: absolute; width: 459px; height: 25px"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnLogIn" runat="server" style="z-index: 1; left: 684px; top: 261px; position: absolute; width: 98px" Text="Log In" OnClick="btnLogIn_Click" />
                <asp:Button ID="btnCreateAccount" runat="server" OnClick="btnCreateAccount_Click" style="z-index: 1; left: 314px; top: 256px; position: absolute; width: 234px" Text="Create Account" />
            </p>
    </form>
</body>
</html>
