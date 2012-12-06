using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
namespace BLL
{
     public class BLLBase<T>
    {
         DALBase<T> dalBase;
         public DALBase<T> DalBase
         {
             get
             {
                 if (dalBase == null)
                 {
                     dalBase = new DALBase<T>();
                 }
                 return dalBase;
             }
             set { dalBase = value; }
         }
        
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
        public IList<T> GetList(string where)
        {
            return DalBase.GetList(where);
        }
        public IList<T> GetList(string where, int pageIndex, int pageSize, out int totalRecord)
        {
            return DalBase.GetList(where, pageIndex, pageSize, out totalRecord);
        }
    }
}
