﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="today.aspx.cs" Inherits="today" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="bootstrap-theme.css" />
    <link rel="stylesheet" type="text/css" href="bootstrap-theme.min.css" />
    <link rel="stylesheet" type="text/css" href="bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="bootstrap.min.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    </div>
    <hr/>
    <div>
    
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" type="button" class="btn btn-primary btn-lg" runat="server" Text="Button" />
        <br />
    
    &nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" type="button" class="btn btn-link" runat="server" Text="今日天氣" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" type="button" class="btn btn-link" runat="server" Text="明日預報" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" type="button" class="btn btn-link" runat="server" Text="一周天氣" OnClick="Button3_Click" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
