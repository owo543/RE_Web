using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace RE_Web
{
    public partial class IDcreat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void creatCheck_Click(object sender, EventArgs e)
        {
            errorText.Text = "---";
            if (creatPasswd_input.Text == checkPasswd_input.Text)
            {
                string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["GameConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(s_data);
                string Acc_check = $"select * from Accounts where account ='" + creatID_input.Text + "'";
                SqlCommand Command = new SqlCommand(Acc_check, connection);
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (!Reader.HasRows)
                {
                    connection.Close();
                    string Acc_check2 = $"insert into [dbo].[Accounts](account,passwd) values (@account,@passwd)";
                    connection.Open();
                    SqlCommand Command2 = new SqlCommand(Acc_check2, connection);
                    Command2.Parameters.Add("@account", SqlDbType.NVarChar);
                    Command2.Parameters["@account"].Value = creatID_input.Text;

                    Command2.Parameters.Add("@passwd", SqlDbType.NVarChar);
                    Command2.Parameters["@passwd"].Value = creatPasswd_input.Text;
                    Command2.ExecuteNonQuery();
                    connection.Close();
                    errorText.Text = "建立成功";

                }
                else
                {
                    errorText.Text = "帳號已註冊";
                    connection.Close();
                }
            }
            else
            {
                errorText.Text = "密碼驗證不正確";
            }
        }

        protected void rePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("test1");
        }
    }
}