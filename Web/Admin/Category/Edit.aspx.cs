using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
public partial class Admin_Category_Edit : System.Web.UI.Page
{
    BLLCategory bllCategory = new BLLCategory();
    Category Category = new Category();
    bool IsNew = true;
    protected void Page_Load(object sender, EventArgs e)
    {
        string paramId = Request["id"];
        int Id;
        if (int.TryParse(paramId, out Id))
        {
            IsNew = false;

        }
        if (!IsPostBack)
        {
            Init();
            if (!IsNew)
            {
                Category = bllCategory.Get(Id);
                LoadForm();
            }
        }
    }
    private void Init() {
        InitParentCates();
    }
    private void InitParentCates()
    {
        rblParent.DataSource = bllCategory.GetCategories();
        rblParent.DataTextField = "Name";
        rblParent.DataValueField = "Id";
        rblParent.DataBind();
        rblParent.Items.Insert(0, new ListItem("无", "0"));
        rblParent.SelectedIndex = 0;
    }
    private void LoadForm()
    {
        tbxTitle.Text = Category.Name;
        tbxOrder.Text = Category.OrderNo.ToString();
        rblParent.SelectedValue = Category.Parent.Id.ToString();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        UpdateForm();
        bllCategory.SaveOrUpdate(Category);
        lblMsg.Text = "保存成功";
        var prs = bllCategory.GetAll<Category>();
        lblMsg.Text += prs.Count;
    }

    private void UpdateForm()
    {
        int order;
        int.TryParse(tbxOrder.Text, out order);
        bllCategory.Update(Category
            , tbxTitle.Text
            , order
            , cbxDisabled.Checked
            , Convert.ToInt32(rblParent.SelectedValue));

    }
}