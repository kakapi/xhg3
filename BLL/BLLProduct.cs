using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
namespace BLL
{
    public class BLLProduct : BLLBase<Product>
    {
        public DAL.DALProduct dalProduct = new DAL.DALProduct();
        public BLLProduct()
        {

        }
        public IList<Product> GetProductsByCate(int cateId, int pageIndex, int pageSize, out int totalRecord)
        {

            IList<Product> products = dalProduct.GetProductsByCategory(cateId, pageIndex, pageSize, out totalRecord);
            return products;
        }


    }
}
