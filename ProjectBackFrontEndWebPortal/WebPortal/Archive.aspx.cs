using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPortal
{
    public partial class Archive : System.Web.UI.Page
    {
        string txt1 = "2019-11-20 09:07", txt2 = "2019-11-20 09:07:09";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0 && TextBox2.Text.Length == 0)
            {
                TextBox1.Text = txt1;
                TextBox2.Text = txt2;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string select = "SELECT * FROM Archiwum WHERE " + "[id] BETWEEN " + "'" + TextBox1.Text + "'" + " AND " + "'" + TextBox2.Text + "'" + ";";
            //string select = "SELECT * FROM Archiwum WHERE " + "[Data odczytu] BETWEEN " + "'"+ TextBox1.Text +"'" + " AND " + "'"+ TextBox2.Text + "'"+ ";";

            SqlDataSource1.DataBind();
            
            /*
            var c = new SqlConnection(ConfigurationManager.ConnectionStrings["BoxJenkinsConnectionString"].ConnectionString); //obiekt odpowiadający za połączenie z bazą danych;
            try
            {
                SqlCommand cmd = new SqlCommand(select, c);
                c.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dbo.Archiwum");
                GridView1.DataSourceID = null;
                GridView1.DataSource = ds;//.Tables["dbo.Archiwum"];
            }
            catch (Exception ex) { }
            */
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}