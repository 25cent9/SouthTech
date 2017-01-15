using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextWebService
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e) {
            var webService = new textWebService.TextWebService();

            toLowerLabel.Text = webService.ToLower(TextBox1.Text);

            toUpperLabel.Text = webService.ToUpper(TextBox1.Text);
        }
    }
}