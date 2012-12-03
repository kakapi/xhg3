using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
public partial class Admin_Product_Edit : System.Web.UI.Page
{
    BLLProduct bllProduct = new BLLProduct();
    Product Product = new Product();
    bool IsNew = true;
    protected void Page_Load(object sender, EventArgs e)
    {
        string paramId = Request["id"];
        Guid Id;
        if (Guid.TryParse(paramId, out Id))
        {
            IsNew = false;

        }
        if (!IsPostBack)
        {
            if (!IsNew)
            {
                Product = bllProduct.Get(Id);
                LoadForm();
            }
        }
    }
    private void LoadForm()
    {
        tbxDescription.Text = Product.Description;
        tbxName.Text = Product.Name;
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        UpdateForm();
        bllProduct.SaveOrUpdate(Product);
        lblMsg.Text = "保存成功";
        var prs = bllProduct.GetAll<Product>();
        lblMsg.Text += prs.Count;
    }

    private void UpdateForm()
    {
        Product.Description = tbxDescription.Text;
        Product.Name = tbxName.Text;
    }
}