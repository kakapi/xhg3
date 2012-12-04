using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Product_Default : System.Web.UI.Page
{
    BLL.BLLProduct bllProduct = new BLL.BLLProduct();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindList();
        }
    }
    private void BindList()
    {
        gv.DataSource = bllProduct.GetAll<Model.Product>();
        gv.DataBind();
    }
}