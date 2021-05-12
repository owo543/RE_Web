using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RE_Web
{
    
    public partial class test1 : System.Web.UI.Page
    {
        static int ct = 30;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["count"] == null)
            {
                Session["count"] = 0;
            }
            /*
            if (Session["login"] == null)
            {
                Response.Redirect("test");
            }*/
            logIn_count.Text = "目前線上人數" + (Application["onlineCount"]).ToString();
        }

        protected void Sign_out_Click(object sender, EventArgs e)
        {
            ct = 30;
            Session["login"] = null;
            Application["onlineCount"] = Convert.ToInt32(Application["onlineCount"]) - 1;
            Response.Redirect("test");
        }

        protected void send_Click(object sender, EventArgs e)
        {
            if(chatInput.Text != "" && chatInput.Text != " ")
            {
                string message = chatInput.Text;
                Application["message"] = Application["message"] + Convert.ToString(Session["A_name"])
                    + ":" + message + "</br>";
            }
            
            
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            ct--;
            Session["time"]= "現在時間" + ct.ToString();
            time2.Text = Convert.ToString(Session["time"]);
            if (Application["message"] != null)
                chatOutput.Text = Application["message"].ToString();

        }
    }
}