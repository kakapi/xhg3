using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
public partial class Notice_Default : System.Web.UI.Page
{
    public Notice Notice;
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadData();
    }
    BLL.BLLNotice bllNotice = new BLL.BLLNotice();
    private void LoadData()
    {
        Guid id =new Guid(Request["id"]);
        Notice = bllNotice.Get(id);
    }
}