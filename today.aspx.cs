﻿using System;
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
        Ultraviolet.Load("http://opendata.epa.gov.tw/ws/Data/UV/?format=xml");
        XmlNodeList UVI = Ultraviolet.GetElementsByTagName("UVI");
        int uvi=0;
        if(Convert.ToInt32(Request.QueryString["city"]) == 1){
            wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_03.xml");
            uvi = Convert.ToInt32(UVI[24].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 2){
            wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_04.xml");
            uvi = Convert.ToInt32(UVI[19].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 3){
            wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_01.xml");
            uvi = Convert.ToInt32(UVI[22].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 4){
            wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_05.xml");
            uvi = Convert.ToInt32(UVI[11].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 5){
            wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_06.xml");
            uvi = Convert.ToInt32(UVI[5].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 6){
            wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_07.xml");
            uvi = Convert.ToInt32(UVI[10].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 7){
            wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_08.xml");
            uvi = Convert.ToInt32(UVI[32].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 8){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_09.xml");
           uvi = Convert.ToInt32(UVI[8].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 9){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_11.xml");
           uvi = Convert.ToInt32(UVI[6].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 10){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_12.xml");
           uvi = Convert.ToInt32(UVI[33].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 11){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_13.xml");
           uvi = Convert.ToInt32(UVI[18].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 12){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_02.xml");
           uvi = Convert.ToInt32(UVI[16].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 13){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_15.xml");
           uvi = Convert.ToInt32(UVI[0].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 14){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_19.xml");
           uvi = Convert.ToInt32(UVI[27].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 15){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_18.xml");
           uvi = Convert.ToInt32(UVI[14].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 16){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_17.xml");
           uvi = Convert.ToInt32(UVI[30].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 17){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_10.xml");
           uvi = Convert.ToInt32(UVI[7].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 18){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_20.xml");
           uvi = Convert.ToInt32(UVI[31].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 19){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_22.xml");
           uvi = Convert.ToInt32(UVI[15].InnerText);

        }else if(Convert.ToInt32(Request.QueryString["city"]) == 20){
           wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_21.xml");
           uvi = Convert.ToInt32(UVI[29].InnerText);

        }      
        XmlNodeList item = wheatherdata.GetElementsByTagName("title");
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
        Label1.Text += "<td> " + wheater + "</td>";
        Label1.Text += "<td>" + rain + "</td></tr></tbody> ";
        Label1.Text += "</table>";
        Label1.Text += "</div>";
        Label1.Text += "<div class=col-xs-3>";
        Label1.Text += "</div>";
        Label1.Text += "<div class=col-xs-4>";
        Label1.Text += "</div>";
        //紫外線
        Label1.Text += "<div class=col-xs-12>";
        if (uvi <= 2)
        {
            Label1.Text += "<h1>紫外線指數</h1></br></br><img src=../img/0-2.jpg class=img-rounded><img>";
        }
        else if (uvi > 2 && uvi <= 5)
        {
            Label1.Text += "<h1>紫外線指數</h1></br></br><img src=../img/3-5.jpg class=img-rounded><img>";
        }
        else if (uvi > 5 && uvi <= 7)
        {
            Label1.Text += "<h1>紫外線指數</h1></br></br><img src=../img/6-7.jpg class=img-rounded><img>";
        }
        else if (uvi > 7 && uvi <= 10)
        {
            Label1.Text += "<h1>紫外線指數</h1></br></br><img src=../img/8-10.jpg class=img-rounded><img>";
        }
        else if (uvi >= 11)
        {
            Label1.Text += "<h1>紫外線指數</h1></br></br><img src=../img/11+.jpg class=img-rounded><img>";
        }
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