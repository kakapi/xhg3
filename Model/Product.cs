using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Product
    {
        public  virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Category Category { get; set; }
        public virtual int OrderNo { get; set; }
        public virtual DateTime LastUpdateTime { get { return lastUpdateTime; } set { lastUpdateTime = value; } }
        public virtual bool Disabled { get { return disabled; } set { disabled = value; } }
        public virtual string  MainImage { get; set; }
        public virtual IList<ProductImage> Images { get; set; }

        public virtual decimal Price { get; set; }
        /// <summary>
        /// 价格单位
        /// </summary>
        public virtual string Unit { get; set; }

        private DateTime lastUpdateTime;
        private bool disabled;
        public Product()
        {
            lastUpdateTime = DateTime.Now;
            disabled = true;
            Images = new List<ProductImage>();
        }
    }
}
