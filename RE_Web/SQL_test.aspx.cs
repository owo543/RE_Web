using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RE_Web
{
    public partial class SQL_test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["GameConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(s_data);
            string sql = $"insert into [dbo.Accounts](account,passwd) values ('ddd','1234')";
            SqlCommand Command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Command);//從Command取得資料存入dataAdapter
            DataSet dataset = new DataSet();//創一個dataset的記憶體資料集
            dataAdapter.Fill(dataset);//將dataAdapter資料存入dataset



            connection.Close();
            //GridView1.DataSource = dataset; //告訴GridView1的DataSource資料來源是dataset
            //GridView1.DataBind(); //資料繫結
        }
    }
}