using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace Q505123 {
    public class Global : System.Web.HttpApplication {

        protected void Application_PreRequestHandlerExecute(object sender, System.EventArgs e) {
            Page page = HttpContext.Current.CurrentHandler as Page;
            if (page != null) {
                page.PreInit += new EventHandler(page_PreInit);
            }
        }

        void page_PreInit(object sender, EventArgs e) {
            Page page = HttpContext.Current.CurrentHandler as Page;
            if (page != null && page.Request.Cookies["theme"] != null) {
                DevExpress.Web.ASPxWebControl.GlobalTheme = page.Request.Cookies["theme"].Value;
            }
        }
    }
}