using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Model;
namespace DAL.Mapping
{
    public class ProductImageMap:ClassMap<ProductImage>
    {
        public ProductImageMap()
        {
            Id(x => x.Id);
            Map(x => x.Path);
            Map(x => x.Type).CustomType<int>();
            References<Product>(x => x.Product);
            Map(x=>x.OrderNo);
        }
    }
}
