﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Place" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Place" HeaderText="Place" ReadOnly="True" SortExpression="Place" />
                <asp:BoundField DataField="Days" HeaderText="Days" SortExpression="Days" />
                <asp:BoundField DataField="Cost" HeaderText="Cost" SortExpression="Cost" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AmanHouseConnectionString %>" SelectCommand="SELECT * FROM [travel] WHERE ([Place] = @Place)">
            <SelectParameters>
                <asp:QueryStringParameter Name="Place" QueryStringField="item" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
