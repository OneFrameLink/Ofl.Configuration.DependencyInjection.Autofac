using System;
using Autofac;
using Ofl.Configuration.Abstractions;

namespace Ofl.Configuration.DependencyInjection.Autofac
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Validate parameters.
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            // Bind.
            builder.RegisterType<ConfigurationConnectionStringManager>().As<IConnectionStringManager>();
        }
    }
}
