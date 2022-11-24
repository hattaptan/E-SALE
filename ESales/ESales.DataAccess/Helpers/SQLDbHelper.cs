using ESales.Core.Helpers;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Extensions.Configuration;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ESales.DataAccess.Helpers
{
    public class SQLDbHelper : NHibernateHelper
    {
        private readonly IConfiguration _configuration;
        public SQLDbHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override ISessionFactory InitializeFactory()
        {
 
            var connection = _configuration.GetConnectionString("PostgreSQLConnection");
            return Fluently
                .Configure()
                    .Database(                       
                       PostgreSQLConfiguration.PostgreSQL82
                        .ConnectionString(connection))
                     .Mappings(t => t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                    .ExposeConfiguration(TreatConfiguration)
                .BuildSessionFactory();
        }

        private static void TreatConfiguration(Configuration configuration)
        {

            //After database created manually, if tables not exist, creates tables automatically.
            // if a new table is mapped afterwards, it migrates only to that table.
            var update = new SchemaUpdate(configuration);
            update.Execute(false, true);
        }
    }
}
