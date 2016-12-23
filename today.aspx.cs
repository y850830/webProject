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
        wheatherdata.Load("http://www.cwb.gov.tw/rss/forecast/36_03.xml");
        XmlNodeList item = wheatherdata.GetElementsByTagName("title");
        String towhea;
        int index = item[2].InnerText.IndexOf("(");
        towhea = item[2].InnerText.Substring(16,index-16);
        Label1.Text = towhea;
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
}