using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP229_F2016_Lesson1
{
    public partial class _Default : Page
    {
        /**
         * <summary>This method executes every time the page loads</summary>
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            HelloLabel.Text = "Good Bye!";
        }
    }
}