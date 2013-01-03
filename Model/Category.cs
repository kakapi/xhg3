using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
  public  class Category
    {
     
      public Category()
      {
          disabled = false;
      } 
      public virtual int Id { get; set; }
     
      public virtual string Name { get; set; }
      public virtual Category Parent{ get; set; }
      public virtual int OrderNo { get; set; }

      public virtual bool Disabled { get { return disabled; } set { disabled = value; } }
      private bool disabled = false;
    }
}
