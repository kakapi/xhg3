using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    BLL.BLLNotice bllNotice = new BLL.BLLNotice();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindNotice();
        }
    }
    private void BindNotice()
    {
        rptNotice.DataSource = bllNotice.GetNoticeListForHomePage().OrderByDescending(x=>x.OrderNum).OrderByDescending(x => x.LastUpdateTime);
        rptNotice.DataBind();
    }
}