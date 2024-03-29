﻿using System.Web;

using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Automapping;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Hql;
using NHibernate.Criterion.Lambda;

namespace DAL
{
    public class HybridSessionBuilder
    {

        private static ISession _currentSession;
        private static ISessionFactory _sessionFactory;

        public ISession GetSession()
        {
//#if DEBUG
           
            var fileName = "d:\\nhpro.log";
        //    HibernatingRhinos.Profiler.Appender.NHibernate.NHibernateProfiler.InitializeOfflineProfiling(fileName);
//#endif
            ISessionFactory factory = getSessionFactory();
            ISession session = getExistingOrNewSession(factory);
            session.FlushMode = FlushMode.Always;
            return session;
        }

        public Configuration GetConfiguration()
        {
            var configuration = new Configuration();
            configuration.Configure();
            return configuration;
        }

        private ISessionFactory getSessionFactory()
        {
            if (_sessionFactory == null)
            {
                IAutomappingConfiguration cfg = new MyAutoMappingCfg();

                MsSqlConfiguration msconfg
                    =MsSqlConfiguration
                    .MsSql2008
                    .ConnectionString(s => s.FromConnectionStringWithKey("xhg"))
                   
                    .ShowSql();
                _sessionFactory = Fluently.Configure()
                .Database(msconfg)
                .Mappings(
                       // m => m.AutoMappings.Add(AutoMap.AssemblyOf<Model.Product>())
                     m => m.FluentMappings.AddFromAssemblyOf<DAL.Mapping.CategoryMap>())
                     
                     
                     
                   
                    .ExposeConfiguration(BuildSchema)
                    .BuildSessionFactory();
            }

            return _sessionFactory;
        }
        private static void BuildSchema(Configuration config)
        {

            SchemaUpdate update = new SchemaUpdate(config);
            update.Execute(false, true);

        }
        private ISession getExistingOrNewSession(ISessionFactory factory)
        {
            if (HttpContext.Current != null)
            {
                ISession session = GetExistingWebSession();
                if (session == null)
                {
                    session = openSessionAndAddToContext(factory);
                }
                else if (!session.IsOpen)
                {
                    session = openSessionAndAddToContext(factory);
                }

                return session;
            }

            if (_currentSession == null)
            {
                _currentSession = factory.OpenSession();
            }
            else if (!_currentSession.IsOpen)
            {
                _currentSession = factory.OpenSession();
            }

            return _currentSession;
        }

        public ISession GetExistingWebSession()
        {
            return HttpContext.Current.Items[GetType().FullName] as ISession;
        }

        private ISession openSessionAndAddToContext(ISessionFactory factory)
        {
            ISession session = factory.OpenSession();
            HttpContext.Current.Items.Remove(GetType().FullName);
            HttpContext.Current.Items.Add(GetType().FullName, session);
            return session;
        }

        public static void ResetSession()
        {
            var builder = new HybridSessionBuilder();
            builder.GetSession().Dispose();
        }
    }

   
}