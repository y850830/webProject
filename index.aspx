<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

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

                <asp:Image ID="Image1" runat="server" DescriptionUrl="~/img/logo.jpg" Height="139px" ImageUrl="~/logo.jpg" Width="752px" />

            </div>
            <hr/>
            <div>

                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" type="button" class="btn btn-primary btn-md" runat="server" Text="首頁" OnClick="Button4_Click" />
                <br /> &nbsp;

                <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" type="button" class="btn btn-link" runat="server" Text="基隆市" OnClick="Button1_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" type="button" class="btn btn-link" runat="server" Text="新北市" OnClick="Button2_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" type="button" class="btn btn-link" runat="server" Text="臺北市" OnClick="Button3_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" type="button" class="btn btn-link" runat="server" Text="桃園市" OnClick="Button4_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button5" type="button" class="btn btn-link" runat="server" Text="新竹市" OnClick="Button5_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button6" type="button" class="btn btn-link" runat="server" Text="苗栗市" OnClick="Button6_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</br>
                <asp:Button ID="Button7" type="button" class="btn btn-link" runat="server" Text="臺中市" OnClick="Button7_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button8" type="button" class="btn btn-link" runat="server" Text="彰化縣" OnClick="Button8_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button9" type="button" class="btn btn-link" runat="server" Text="雲林縣" OnClick="Button9_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button10" type="button" class="btn btn-link" runat="server" Text="嘉義縣" OnClick="Button10_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button11" type="button" class="btn btn-link" runat="server" Text="台南市" OnClick="Button11_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</br>
                <asp:Button ID="Button12" type="button" class="btn btn-link" runat="server" Text="高雄市" OnClick="Button12_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button13" type="button" class="btn btn-link" runat="server" Text="屏東線" OnClick="Button13_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button14" type="button" class="btn btn-link" runat="server" Text="台東縣" OnClick="Button14_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button15" type="button" class="btn btn-link" runat="server" Text="花蓮縣" OnClick="Button15_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button16" type="button" class="btn btn-link" runat="server" Text="宜蘭縣" OnClick="Button16_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</br>
                <asp:Button ID="Button17" type="button" class="btn btn-link" runat="server" Text="南投縣" OnClick="Button17_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button18" type="button" class="btn btn-link" runat="server" Text="澎湖縣" OnClick="Button18_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button19" type="button" class="btn btn-link" runat="server" Text="連江縣" OnClick="Button19_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button20" type="button" class="btn btn-link" runat="server" Text="金門縣" OnClick="Button20_Click" />
                <br />
                <br /> &nbsp;&nbsp;&nbsp;
                <br />
                <br />
                <br />
            </div>
        </form>
    </body>

    </html>