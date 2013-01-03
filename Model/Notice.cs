using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Notice
    {
        public virtual Guid Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Content { get; set; }
        public virtual int OrderNo { get; set; }
        public virtual DateTime LastUpdateTime { get; set; }
        public virtual bool Disabled { get; set; }
    }
}
