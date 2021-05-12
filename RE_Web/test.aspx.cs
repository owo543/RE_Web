using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RE_Web
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ID_input.Text = "請輸入帳號";
                Passwd_input.Text = "請輸入密碼";
                name.Text = "請輸入暱稱";
            }
            if (Convert.ToString(Session["login"]) == "ok")
            {
                Response.Redirect("test1");
            }
        }

        protected void Sign_in_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
            Session["ID"] = ID_input.Text;
            Session["Passwd"] = Passwd_input.Text;
            Session["A_name"] = name.Text;
            //Response.Redirect("Handler1.ashx");
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["GameConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(s_data);
            string Acc_check = $"select * from Accounts where account ='"+ ID_input.Text+"'";
            //SqlCommand Command = new SqlCommand($"select * from Accounts", connection);
            SqlCommand Command = new SqlCommand(Acc_check, connection);
            connection.Open();
            SqlDataReader Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    string sqlPass = Reader["passwd"].ToString();
                    if (sqlPass == Passwd_input.Text)
                    {
                        Session["login"] = "ok";
                        Application["onlineCount"] = Convert.ToInt32(Application["onlineCount"]) + 1;
                        Response.Redirect("test1");
                    }
                    else
                    {
                        Label2.Text = "密碼錯誤";
                        Passwd_input.Text = "";
                    }
                }
            }
            else
            {
                Label1.Text = "帳號錯誤";
                ID_input.Text = "";
            }
            connection.Close();
            /*
            if (ID_input.Text == "000")
            {                
                if (Passwd_input.Text == "9999")
                {
                    Session["login"] = "ok";                    
                    Application["onlineCount"] = Convert.ToInt32(Application["onlineCount"]) + 1;
                    Response.Redirect("test1");
                }
                else
                {
                    Label2.Text = "密碼錯誤";
                    Passwd_input.Text = "";
                }
            }
            else
            {
                Label1.Text = "帳號錯誤";
                ID_input.Text = "";
            }
            */

        }

        protected void creatAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("IDcreat");
        }
    }
}