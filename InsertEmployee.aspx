<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertEmployee.aspx.cs" Inherits="EmployeeEntityFramework.InsertEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblEmpId" runat="server" Text="Employee ID"></asp:Label>
            <asp:TextBox ID="txtEmpId" runat="server"></asp:TextBox> <br /> <br />

            <asp:Label ID="lblEmpName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox> <br /> <br />

            <asp:Label ID="lblEmpSal" runat="server" Text="Salary"></asp:Label>
            <asp:TextBox ID="txtEmpSal" runat="server"></asp:TextBox> <br /> <br />

            <asp:Label ID="lblEmpDes" runat="server" Text="Designation"></asp:Label>
            <asp:TextBox ID="txtEmpDes" runat="server"></asp:TextBox> <br /> <br />

            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
        </div>
    </form>
</body>
</html>
