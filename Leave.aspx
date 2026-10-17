<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Leave.aspx.cs" Inherits="Experiment_6.Leave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <h2>Employee Leave Application</h2>

 Leave Date : <asp:Label ID="lblDate" runat="server"></asp:Label> <br />
 Employee Name : <asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox> <br />
 Employee Department : <asp:TextBox ID="txtEmpDept" runat="server"></asp:TextBox> <br />
 Employee Designation : <asp:TextBox ID="txtEmpDesig" runat="server"></asp:TextBox> <br />
 Reason for Leave : <asp:TextBox ID="txtReason" runat="server"></asp:TextBox> <br />
 <asp:Button ID="btnApply" runat="server" Text="Apply for Leave" OnClick="btnApply_Click" /> <br />
 <asp:Label ID="lblResult" runat="server" ForeColor="Blue"></asp:Label>
         <asp:Label ID="lblLeave" runat="server"
            Text="Leave Page"></asp:Label>

        <br /><br />


        <asp:Button ID="btnLogout" runat="server"
            Text="Logout"
            OnClick="btnLogout_Click" />

    </form>
</body>
</html>
