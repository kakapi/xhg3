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
    BLLCategory bllCate = new BLLCategory();
    bool IsNew = true;
    protected void Page_Load(object sender, EventArgs e)
    {
        string paramId = Request["id"];
        Guid Id;
        if (Guid.TryParse(paramId, out Id))
        {
            IsNew = false;

        }

        fu.Visible = !IsNew;
      
        if (!IsPostBack)
        {
            Init();
            if (!IsNew)
            {
                Product = bllProduct.Get(Id);
                LoadForm();
            }
        }
    }
    private void Init()
    {
        BindTop();
        BindSecond();
    }
    private void BindTop()
    {
        ddlCateTop.DataSource = bllCate.GetCategories();
        ddlCateTop.DataBind();
        
    }
   
    

    private void BindSecond()
    {
        int parentId =Convert.ToInt32( ddlCateTop.SelectedValue);
        ddlCateSecond.DataSource = bllCate.GetCategories(parentId);
        ddlCateSecond.DataBind();
    }
    protected void ddlCateTop_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlCateSecond.Items.Clear();
        BindSecond();
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
        FineUI.Alert.ShowInParent("保存成功", "", FineUI.MessageBoxIcon.Information
            ,"window.location.href='edit.aspx?id="+Product.Id+"'");
       // Response.Redirect("edit.aspx?id=" + Product.Id);
      
    }

    private void UpdateForm()
    {
        Product.Description = tbxDescription.Text;
        Product.Name = tbxName.Text;
        
    }
}