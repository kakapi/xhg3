using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Model;
namespace DAL.Mapping
{
    public class ProductMap:ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.Id);
            Map(x => x.Description);
            Map(x => x.Name);
            Map(x => x.Disabled);
            Map(x => x.LastUpdateTime);
            Map(x => x.OrderNo);
            HasMany<ProductImage>(x => x.Images).Cascade.All();
            References<Category>(x => x.Category);
            Map(x => x.MainImage);
            Map(x => x.Price);
            Map(x => x.Unit);
        }
    }
}
