using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
namespace DAL
{
   public class DALBase<T>
    {
       ISession session = new HybridSessionBuilder().GetSession();
       public T Get(object id)
       {
           return session.Get<T>(id);
           
       }
       public void Delete(T t)
       {
           session.Delete(t);
           session.Flush();
       }
       public void SaveOrUpdate(T t)
       {
           session.SaveOrUpdate(t);
           session.Flush();
       }
       public IList<T> GetAll<T>() where T:class
       {
            return session.QueryOver<T>().List();
       }
    }
}
