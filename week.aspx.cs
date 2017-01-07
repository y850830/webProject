using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class week : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XmlDocument wheatherdata = new XmlDocument();
        if(Convert.ToInt32(Request.QueryString["city"]) == 1){
            wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_03.xml");

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 2){
            wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_04.xml");

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 3){
            wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_01.xml");

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 4){
            wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_05.xml");

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 5){
            wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_06.xml");
        }else if(Convert.ToInt32(Request.QueryString["city"]) == 6){
            wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_07.xml");

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 7){
            wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_08.xml");

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 8){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_09.xml");
        }else if(Convert.ToInt32(Request.QueryString["city"]) == 9){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_11.xml");
        }else if(Convert.ToInt32(Request.QueryString["city"]) == 10){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_12.xml");

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 11){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_13.xml");

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 12){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_02.xml");

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 13){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_15.xml");
        }else if(Convert.ToInt32(Request.QueryString["city"]) == 14){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_19.xml");

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 15){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_18.xml");

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 16){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_17.xml");

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 17){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_10.xml");
        }else if(Convert.ToInt32(Request.QueryString["city"]) == 18){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_20.xml");

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 19){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_22.xml");

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 20){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_21.xml");

        }  
        XmlNodeList item = wheatherdata.GetElementsByTagName("description");
        String temperature, wheater, rain, time;      
        //天氣資料
        string[] wheatherdescription = item[3].InnerText.Split('<br>');
        //預報一
        Label1.Text = "<div class=col-xs-5>";
        Label1.Text += "<table class=table>";
        Label1.Text += "<thead><tr><th>氣象</th></tr></thead>";
        Label1.Text += "<tbody><tr>";
        for(int i=0;i<wheatherdescription.Length;i++){
            Label1.Text += "<td>"+wheatherdescription[i]+"</td>";
        }
        Label1.Text += "</tr></tbody>";
        Label1.Text += "</table>";
        //紫外線
        Label1.Text += "<div class=col-xs-5>";
        Label1.Text += "</div>";
        Label1.Text += "<div class=col-xs-2>";
        Label1.Text += "</div>";
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("today.aspx?&city="+Request.QueryString["city"]);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("tomorrow.aspx?&city="+Request.QueryString["city"]);
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("week.aspx?&city="+Request.QueryString["city"]);
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }
}