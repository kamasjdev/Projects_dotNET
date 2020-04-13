using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebPortal
{
    public partial class Measures : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            GridView1.DataBind();//aktualizacja elementu
            string polaczenie = "";
            //Accessing TemplateField Column controls.
            foreach (GridViewRow gr in GridView1.Rows)
            {
                polaczenie = gr.Cells[3].Text;
            }
            if (polaczenie == "M") Label1.Text = "Połączono z Mutex";else Label1.Text ="Brak łączności";
        }
    }
}