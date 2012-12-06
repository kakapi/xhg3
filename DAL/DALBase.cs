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
        string whereBase;

        public DALBase()
        {
            whereBase = string.Format("select M from {0} as M where 1=1 ", typeof(T).Name);
        }
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
        public IList<T> GetAll<T>() where T : class
        {
            return session.QueryOver<T>().List();
        }

        public IList<T> GetList(string where, int pageIndex, int pageSize, out int totalRecord)
        {
            where = whereBase + where;
            var allList = session.CreateQuery(where).List<T>();
            totalRecord = allList.Count;
            var pagedList = allList.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return pagedList;
        }
        public IList<T> GetList(string where)
        {
            int totalRecord = 0;
            return GetList(where, 1, 999, out totalRecord);
        }
        public IList<T> GetList(string where,int pageIndex,int pageSize)
        {
            int totalRecord = 0;
            return GetList(where, pageIndex, pageSize, out totalRecord);
        }
        public IList<T> GetList(string where,int pageSize)
        {
          
            return GetList(where, 1, pageSize);
        }
    }
}
