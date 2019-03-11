using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_27_HelloWorldWebsite
{
    public partial class SiteMaster : MasterPage
    {
        static int counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Label1.Text = counter.ToString();
            counter++;
        }
    }
}