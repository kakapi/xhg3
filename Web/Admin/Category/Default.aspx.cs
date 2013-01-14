using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Category_Default : System.Web.UI.Page
{
    BLL.BLLCategory bllCate = new BLL.BLLCategory();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Bind();
    }
    private void Bind()
    {
        rptCates.DataSource = bllCate.GetAll<Model.Category>();
        rptCates.DataBind();
    }
}