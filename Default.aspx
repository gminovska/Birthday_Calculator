<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Birthday Calculator</title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>

    <h1>Birthday Calculator</h1>

        <hr />
        <p>Enter your name <asp:TextBox ID="Name" runat="server"></asp:TextBox></p>
        <p>When is your next birthday?</p>
        <asp:Calendar ID="Calendar1" runat="server"  OnDayRender="Calendar1_DayRender" BackColor="#99ff99"></asp:Calendar>
        
        <p><asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click"/>
            <p id="result"><asp:Label ID="ResultLabel" runat="server" Text="" ></asp:Label></p>
        </p>
    </div>
    </form>
</body>
</html>


