<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tomorrow.aspx.cs" Inherits="tomorrow" %>

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

                <asp:Image ID="Image1" runat="server" DescriptionUrl="~/img/logo.jpg" Height="129px" ImageUrl="~/logo.jpg" Width="749px" />

            </div>
            <hr/>
            <div>

                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" type="button" class="btn btn-primary btn-md" runat="server" Text="首頁" OnClick="Button4_Click" />
                <br /> &nbsp;

                <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" type="button" class="btn btn-link" runat="server" Text="今日天氣" OnClick="Button1_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" type="button" class="btn btn-link" runat="server" Text="明日預報" OnClick="Button2_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" type="button" class="btn btn-link" runat="server" Text="一周天氣" OnClick="Button3_Click" />
                <br />
                <br /> &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                <br />
                <br />
            </div>
        </form>
    </body>

    </html>