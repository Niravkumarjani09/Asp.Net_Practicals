<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Companies.aspx.cs" Inherits="p9_26.Companies" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Company Placement Summary</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <style>
        body { font-family: Arial, sans-serif; margin: 0; background: #f3f6fb; color: #202938; }
        .wrap { max-width: 1100px; margin: 35px auto; padding: 0 18px; }
        h1, h2 { color: #173b70; }
        .panel { background: white; padding: 20px; margin: 18px 0; border-radius: 9px; box-shadow: 0 2px 9px #0000000d; overflow-x: auto; }
        table { border-collapse: collapse; width: 100%; }
        th, td { border: 1px solid #d9e1ec; padding: 10px; text-align: left; }
        th { background: #eaf1fb; }
        .company { border-bottom: 1px solid #d9e1ec; padding: 12px 4px; }
        .link { display: inline-block; margin-top: 12px; padding: 10px 16px; background: #1756a9; color: white; text-decoration: none; border-radius: 5px; }
        .message { color: #b42318; font-weight: bold; }
    </style>
</head>
<body>
<form id="form1" runat="server">
<div class="wrap">
    <h1>Company Placement Summary</h1>
    <asp:Label ID="lblMessage" runat="server" CssClass="message" />
    <div class="panel">
        <h2>Company Details Using Repeater</h2>
        <asp:Repeater ID="rptCompanies" runat="server">
            <HeaderTemplate>
                <table>
                    <tr><th>Company</th><th>Total Placements</th><th>Highest Package (LPA)</th></tr>
            </HeaderTemplate>
            <ItemTemplate>
                    <tr>
                        <td><%# Eval("CompanyName") %></td>
                        <td><%# Eval("TotalPlacements") %></td>
                        <td><%# Eval("HighestPackage", "{0:N2}") %></td>
                    </tr>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
    </div>
    <div class="panel">
        <h2>Company Details Using DataList</h2>
        <asp:DataList ID="dlPlacements" runat="server" RepeatColumns="2" RepeatDirection="Horizontal" Width="100%">
            <ItemTemplate>
                <div class="company">
                    <strong>Company:</strong> <%# Eval("CompanyName") %><br />
                    <strong>Job Role:</strong> <%# Eval("JobRole") %><br />
                    <strong>Package:</strong> <%# Eval("PackageLPA", "{0:N2}") %> LPA<br />
                    <strong>Student ID:</strong> <%# Eval("StudentId") %>
                </div>
            </ItemTemplate>
        </asp:DataList>
        <a class="link" href="Default.aspx">Back to Dashboard</a>
    </div>
</div>
</form>
</body>
</html>
