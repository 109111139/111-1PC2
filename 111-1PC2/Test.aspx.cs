using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i_In = 66377;
            double d_Ou = 0;
            double C = (double)i_In;
            d_Ou = (C*9/5)+ 32;
            Response.Write(d_Ou);
                
        }
    }
}