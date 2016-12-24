using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class tomorrow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XmlDocument wheatherdata = new XmlDocument();
        XmlDocument Ultraviolet = new XmlDocument();
        wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_03.xml");
        Ultraviolet.Load("http://opendata.epa.gov.tw/ws/Data/UVIF/?format=xml");
        XmlNodeList item = wheatherdata.GetElementsByTagName("description");
        XmlNodeList UVI = Ultraviolet.GetElementsByTagName("UVI");
        String temperature, wheater, rain, time;
        String temperature2, wheater2, rain2, time2;
        string[] wheatherdescription = item[1].InnerText.Split(' ');
        //天氣資料
        temperature = wheatherdescription[3] + " " + wheatherdescription[4] + " " + wheatherdescription[5];
        wheater = wheatherdescription[1];
        rain = wheatherdescription[7];
        time = wheatherdescription[0];
        temperature2 = wheatherdescription[11] + " " + wheatherdescription[12] + " " + wheatherdescription[13];
        wheater2 = wheatherdescription[9];
        rain2 = wheatherdescription[15];
        time2 = wheatherdescription[8];

        //預報一
        Label1.Text = "<div class=col-xs-5>";
        Label1.Text += "<table class=table>";
        Label1.Text += "<thead><tr><th>時間</th><th>溫度</th><th>天氣</th><th>  降雨機率</th></tr></thead>";
        Label1.Text += "<tbody><tr><td>" + time + "</td>";
        Label1.Text += "<td>" + temperature + "</td>";
        if (String.ReferenceEquals(wheater, "多雲時陰"))
        {
            Label1.Text += "<td> " + wheater + "</br></br><img src=../cloudy.jpg class=img-rounded>" + "</td>";
        }
        else
        {
            Label1.Text += "<td> " + wheater + "</td>";
        }
        Label1.Text += "<td>" + rain + "</td></tr>";

        //預報二
        Label1.Text += "<tr><td>" + time2 + "</td>";
        Label1.Text += "<td>" + temperature2 + "</td>";
        if (String.ReferenceEquals(wheater2, "多雲時陰"))
        {
            Label1.Text += "<td> " + wheater2 + "</br></br><img src=../cloudy.jpg class=img-rounded>" + "</td>";
        }
        else
        {
            Label1.Text += "<td> " + wheater2 + "</td>";
        }
        Label1.Text += "<td>" + rain2 + "</td></tr></tbody> ";
        Label1.Text += "</table>";
        //紫外線
        Label1.Text += "<div class=col-xs-5>";
        if (Convert.ToInt32(UVI[18].InnerText) <= 2)
        {
            Label1.Text += "<center><h1>紫外線預報</h1></br></br><img src=../0-2.jpg class=img-rounded><img></center>";
        }
        else if (Convert.ToInt32(UVI[18].InnerText) > 2 && Convert.ToInt32(UVI[18].InnerText) <= 5)
        {
            Label1.Text += "<center><h1>紫外線預報</h1></br></br><img src=../3-5.jpg class=img-rounded><img></center>";
        }
        else if (Convert.ToInt32(UVI[18].InnerText) > 5 && Convert.ToInt32(UVI[18].InnerText) <= 7)
        {
            Label1.Text += "<center><h1>紫外線預報</h1></br></br><img src=../6-7.jpg class=img-rounded><img></center>";
        }
        else if (Convert.ToInt32(UVI[18].InnerText) > 7 && Convert.ToInt32(UVI[18].InnerText) <= 10)
        {
            Label1.Text += "<center><h1>紫外線預報</h1></br></br><img src=../8-10.jpg class=img-rounded><img></center>";
        }
        else if (Convert.ToInt32(UVI[18].InnerText) >= 11)
        {
            Label1.Text += "<center><h1>紫外線預報</h1></br></br><img src=../11+.jpg class=img-rounded><img></center>";
        }
        Label1.Text += "</div>";
        Label1.Text += "<div class=col-xs-2>";
        Label1.Text += "</div>";
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("today.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("tomorrow.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {

    }

    protected void Button4_Click(object sender, EventArgs e)
    {

    }
}