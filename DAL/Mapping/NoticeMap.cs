using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Model;
namespace DAL.Mapping
{
    public class NoticeMap:ClassMap<Notice>
    {
        public NoticeMap()
        {
            Id(x => x.Id);
            Map(x => x.LastUpdateTime);
            Map(x => x.OrderNo);
            Map(x => x.Title);
            Map(x => x.Content);
        }
    }
}
