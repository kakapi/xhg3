using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
namespace BLL
{
   public class BLLProduct:BLLBase<Product>
    {
       public BLLProduct()
       {
           DalBase = new DALProduct();
       }
       

    }
}
