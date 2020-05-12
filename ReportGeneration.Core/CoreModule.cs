using Autofac;
using ReportGeneration.Core.Data;
using ReportGeneration.Core.Repository;
using ReportGeneration.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGeneration.Core
{
    public class CoreModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public CoreModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ReportDbContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<PostUnitOfWork>().As<IPostUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<PostRepository>().As<IPostRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<PostService>().As<IPostService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
