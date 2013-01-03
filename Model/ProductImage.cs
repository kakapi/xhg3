using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ProductImage
    {
        public  virtual Guid Id { get; set; }
        public virtual Product Product { get; set; }
        public virtual string Path { get; set; }
        public virtual ImageType Type { get; set; }
        public virtual int OrderNo { get; set; }
    }
    public enum ImageType
    {
      Main//产品列表里的图片
        ,Detail//商品描述里的图片
    }
}
