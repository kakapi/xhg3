using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
namespace DAL.Mapping
{
   public class CategoryMap:ClassMap<Model.Category>
    {
       public CategoryMap()
       {
          
           Map(x => x.OrderNo);
           Map(x => x.Name).Unique();
           Id(x => x.Id);
           References<Model.Category>(x => x.Parent);
           
       }
    }
}
