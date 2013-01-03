using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
public partial class Products_Default : System.Web.UI.Page
{
    BLLProduct bllProduct = new BLLProduct();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }
    protected void LoadData()
    {
        int cateid;
        int.TryParse(Request["cateid"],out cateid);
        int totalRecord;
        IList<Model.Product> productList = bllProduct.GetProductsByCate(cateid, pager.CurrentPageIndex, pager.PageSize,
            out totalRecord);
        pager.RecordCount = totalRecord;
        rptProducts.DataSource = productList;
        rptProducts.DataBind();
    }
}