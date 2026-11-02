<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="p9_26.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Placement Dashboard</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <style>
        body { font-family: Arial, sans-serif; margin: 0; background: #f3f6fb; color: #202938; }
        .wrap { max-width: 1100px; margin: 35px auto; padding: 0 18px; }
        h1 { color: #173b70; margin-bottom: 6px; }
        .sub { color: #667085; margin-top: 0; }
        .cards { display: flex; flex-wrap: wrap; gap: 14px; margin: 22px 0; }
        .card { background: white; border-radius: 9px; padding: 18px 22px; min-width: 180px; flex: 1; box-shadow: 0 2px 9px #0000000d; }
        .card span { display: block; color: #667085; font-size: 14px; }
        .card strong { display: block; font-size: 26px; color: #1756a9; margin-top: 9px; }
        .panel { background: white; padding: 20px; border-radius: 9px; box-shadow: 0 2px 9px #0000000d; overflow-x: auto; }
        h2 { color: #173b70; font-size: 20px; }
        table { border-collapse: collapse; width: 100%; }
        th, td { border: 1px solid #d9e1ec; padding: 10px; text-align: left; }
        th { background: #eaf1fb; }
        .link { display: inline-block; margin-top: 18px; padding: 10px 16px; background: #1756a9; color: white; text-decoration: none; border-radius: 5px; }
        .message { color: #b42318; font-weight: bold; }
    </style>
</head>
<body>
<form id="form1" runat="server">
<div class="wrap">
    <h1>Placement Dashboard</h1>
    <p class="sub">Placement Summary and Student Records</p>
    <asp:Label ID="lblMessage" runat="server" CssClass="message" />
    <div class="cards">
        <div class="card"><span>Total Placement Records</span><strong><asp:Label ID="lblTotal" runat="server" Text="0" /></strong></div>
        <div class="card"><span>Students Placed</span><strong><asp:Label ID="lblPlaced" runat="server" Text="0" /></strong></div>
        <div class="card"><span>Companies</span><strong><asp:Label ID="lblCompanies" runat="server" Text="0" /></strong></div>
        <div class="card"><span>Highest Package (LPA)</span><strong><asp:Label ID="lblHighestPackage" runat="server" Text="0.00" /></strong></div>
    </div>
    <div class="panel">
        <h2>Student Placement Records</h2>
        <asp:GridView ID="gvPlacements" runat="server" AutoGenerateColumns="False"
            DataKeyNames="PlacementId" EmptyDataText="No student placement records found."
            GridLines="Horizontal" Width="100%">
            <Columns>
                <asp:BoundField DataField="PlacementId" HeaderText="Placement ID" />
                <asp:BoundField DataField="StudentId" HeaderText="Student ID" />
                <asp:BoundField DataField="CompanyName" HeaderText="Company" />
                <asp:BoundField DataField="JobRole" HeaderText="Job Role" />
                <asp:BoundField DataField="PackageLPA" HeaderText="Package (LPA)" DataFormatString="{0:N2}" />
            </Columns>
        </asp:GridView>
        <a class="link" href="Companies.aspx">View Company Summary</a>
    </div>
</div>
</form>
</body>
</html>
