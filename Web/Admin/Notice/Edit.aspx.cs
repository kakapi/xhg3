using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
public partial class Admin_Notice_Edit : System.Web.UI.Page
{
    BLLNotice bllNotice = new BLLNotice();
    Notice Notice = new Notice();
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
                Notice = bllNotice.Get(Id);
                LoadForm();
            }
        }
    }
    private void LoadForm()
    {
        tbxTitle.Text = Notice.Title;
        tbxContent.Text = Notice.Content;
        tbxOrder.Text = Notice.OrderNum.ToString();
        cbxEnable.Checked = !Notice.Disabled;
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        UpdateForm();
        bllNotice.SaveOrUpdate(Notice);
        lblMsg.Text = "保存成功";
        var prs = bllNotice.GetAll<Notice>();
        lblMsg.Text += prs.Count;
    }

    private void UpdateForm()
    {
        Notice.Title = tbxTitle.Text;
        Notice.Content = tbxContent.Text;
        int order;
        int.TryParse(tbxOrder.Text, out order);
        Notice.OrderNum = order;
        Notice.Disabled = !cbxEnable.Checked;
        Notice.LastUpdateTime = DateTime.Now;
    }
}