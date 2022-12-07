using DevExpress.Web.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q505123 {
    public partial class Site1 : System.Web.UI.MasterPage {
        protected void Page_Init(object sender, EventArgs e) {
            ASPxComboBox1.DataSource = ThemesProvider.GetThemes();
            ASPxComboBox1.DataBind();
        }

        protected void Page_PreInit(object sender, EventArgs e) {
            // This event is not raised for the Master Page
        }  
    }
}