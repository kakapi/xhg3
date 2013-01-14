using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
namespace DAL
{
    public class DALProduct : DALBase<Model.Product>
    {
        public IList<Product> GetProductsByCategory(int cateId, int pageIndex, int pageSize, out int totalRecord)
        {
            string where = string.Empty;
            if (cateId > 0 )
            {
                where += " and M.Category.Id=" + cateId;
            }
            return GetList(where, pageIndex, pageSize, out totalRecord);
        }
    }
}
