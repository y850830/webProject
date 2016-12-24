using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class today : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XmlDocument wheatherdata = new XmlDocument();
        XmlDocument Ultraviolet = new XmlDocument();
        wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_03.xml");
        Ultraviolet.Load("http://opendata.epa.gov.tw/ws/Data/UV/?format=xml");
        XmlNodeList item = wheatherdata.GetElementsByTagName("title");
        XmlNodeList UVI = Ultraviolet.GetElementsByTagName("UVI");
        String temperature, wheater,rain,time;
        //天氣資料
        string[] wheatherdescription = item[2].InnerText.Split(' ');
        time = wheatherdescription[2];
        wheater = wheatherdescription[3];
        temperature = wheatherdescription[5] + " " + wheatherdescription[6] + " " + wheatherdescription[7];
        rain = wheatherdescription[9];

        //天氣資訊
        Label1.Text = "<div class=col-xs-5>";
        Label1.Text += "<h3>"+ time + "</h3>";
        Label1.Text += "<table class=table>";
        Label1.Text += "<thead><tr><th>溫度</th><th>天氣</th><th>  降雨機率</th></tr></thead>";
        Label1.Text += "<tbody><tr><td>" + temperature + "</td>";
        if (String.ReferenceEquals(wheater, "多雲時陰"))
        {
            Label1.Text += "<td> " + wheater + "</br></br><img src=../cloudy.jpg class=img-rounded>" + "</td>";
        }
        else
        {
            Label1.Text += "<td> " + wheater + "</td>";
        }
        Label1.Text += "<td>" + rain + "</td></tr></tbody> ";
        Label1.Text += "</table>";
        Label1.Text += "</div>";
        Label1.Text += "<div class=col-xs-3>";
        Label1.Text += "</div>";
        Label1.Text += "<div class=col-xs-4>";
        Label1.Text += "</div>";
        //紫外線
        Label1.Text += "<div class=col-xs-12>";
        if (Convert.ToInt32(UVI[UVI.Count - 1].InnerText) <= 2)
        {
            Label1.Text += "<h1>紫外線指數</h1></br></br><img src=../0-2.jpg class=img-rounded><img>";
        }
        else if (Convert.ToInt32(UVI[UVI.Count - 1].InnerText) > 2 && Convert.ToInt32(UVI[UVI.Count - 1].InnerText) <= 5)
        {
            Label1.Text += "<h1>紫外線指數</h1></br></br><img src=../3-5.jpg class=img-rounded><img>";
        }
        else if (Convert.ToInt32(UVI[UVI.Count - 1].InnerText) > 5 && Convert.ToInt32(UVI[UVI.Count - 1].InnerText) <= 7)
        {
            Label1.Text += "<h1>紫外線指數</h1></br></br><img src=../6-7.jpg class=img-rounded><img>";
        }
        else if (Convert.ToInt32(UVI[UVI.Count - 1].InnerText) > 7 && Convert.ToInt32(UVI[UVI.Count - 1].InnerText) <= 10)
        {
            Label1.Text += "<h1>紫外線指數</h1></br></br><img src=../8-10.jpg class=img-rounded><img>";
        }
        else if (Convert.ToInt32(UVI[UVI.Count - 1].InnerText) >= 11)
        {
            Label1.Text += "<h1>紫外線指數</h1></br></br><img src=../11+.jpg class=img-rounded><img>";
        }
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