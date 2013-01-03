using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
namespace BLL
{
    public class BLLCategory:BLLBase<Model.Category>
    {
        public DAL.DALNotice dalNotice = new DAL.DALNotice();
        public IList<Category> GetCategories()
        {
            return GetCategories(0);
        }
        public IList<Category> GetCategories(int parentId)
        {
            string where = string.Empty;
            if (parentId == null || parentId <= 0)
            {
                where += " and M.Parent is null ";
            }
            else
            {
                where += " and M.Parent.Id=" + parentId;
            }
            return GetList(where);
        }
        public bool Update(Category old, string name, int orderNo, bool disabled, int parentId)
        {
            bool result = true;
            if (!string.IsNullOrEmpty(name))
                old.Name = name;
            old.OrderNo = orderNo;
            old.Disabled = disabled;
            Category parentCate = Get(parentId);
            if (parentCate != null)
            {
                old.Parent = parentCate;
            }
            return result;
        }
      
    }
}
