using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
namespace xhgTest.BLLTest
{
   public class CategoryTest
   {
       [Fact]
        public void GetTopCategoriesTest()
        {
            BLL.BLLCategory bllCate = new BLL.BLLCategory();
            bllCate.GetCategories();

            Model.Category c1 = new Model.Category();
            c1.Name = "cate1";
           
            bllCate.SaveOrUpdate(c1);
            Assert.True(bllCate.GetCategories().Count > 0);
        }
    }
}
