using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
namespace BLL
{
    public class BLLBase<T>
    {
        public DALBase<T> DalBase{get;set;}
        
        public T Get(object id)
        {
            return DalBase.Get(id);
        }
        public void Delete(T t)
        {
            DalBase.Delete(t);
        }
        public void SaveOrUpdate(T t)
        {
            DalBase.SaveOrUpdate(t);
        }
        public IList<T> GetAll<T>() where T:class
        {
           return DalBase.GetAll<T>();
        }
    }
}
