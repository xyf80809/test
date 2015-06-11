using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testweb
{
    public partial class _Default : System.Web.UI.Page
    {
        int a;
        string t = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("aaa");
            }
        }
    }
}
