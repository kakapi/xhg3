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

        //fu.Visible = !IsNew;
      
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
        Category topCate = Product.Category.Parent;
        ddlCateTop.SelectedValue = topCate.Id.ToString();
        tbxPrice.Text = Product.Price.ToString();
        tbxPriceUnit.Text = Product.Unit;
        Category childCate = Product.Category;
        imgProduct.ImageUrl = Product.MainImage;
        BindSecond();
        ddlCateSecond.SelectedValue = childCate.Id.ToString();


        //图片
        imgProduct.ImageUrl = Product.MainImage;
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        UpdateForm();
        bllProduct.SaveOrUpdate(Product);
        UploadImage(Product.Id.ToString());
        Product.MainImage = "/Storage/" + Product.Id.ToString() + ".jpg";
        bllProduct.SaveOrUpdate(Product);
        Response.Redirect("edit.aspx?id=" + Product.Id);
      
    }

    private void UpdateForm()
    {
        Product.Description = tbxDescription.Text;
        Product.Name = tbxName.Text;
        Product.Category = bllCate.Get(Convert.ToInt32( ddlCateSecond.SelectedValue));
        Product.Price = decimal.Parse(tbxPrice.Text);
        Product.Unit = tbxPriceUnit.Text;

        
    }
    private void UploadImage(string name)
    { 
        string path=Server.MapPath( "/Storage/"+name+".jpg");

        fu.SaveAs(path);
    }
}