using AutoMapper;
using Core.Application;
using Core.Data.Repositories;
using Core.Domain.Interfaces;
using Core.Domain.Interfaces.Repositories;
using Core.Infrastructure;
using Core.Utils.Extension;
using Microsoft.Extensions.DependencyInjection;
using Pedidos.Application;
using Pedidos.Application.AutoMapper;
using Pedidos.Application.Interfaces;
using Pedidos.Data.Context;

namespace Pedidos.Configuration
{
    /// <summary>
    /// Classe para registro o app
    /// </summary>
    public static class AppRegistration
    {
        /// <summary>
        /// Adicionar services dos chamados
        /// </summary>
        /// <param name="services">Service collection</param>
        /// <returns>Service collection</returns>
        public static IServiceCollection AddPedidos(this IServiceCollection services)
        {
            services.AddEntity()
                    .AddHttpClient()
                    .AddHttpContextAccessor();

            services.AddTransient(s => ServiceAppProxy<IDashboardAppService>.Wrap<ServiceAppProxy<IDashboardAppService>>(s, new DashboardAppService(s)));
            services.AddTransient<HttpTokenClientFactory>();

            services.RegisterAllTypes(typeof(IUseCase<,>), new[] { typeof(AppRegistration).Assembly });
            services.AddScoped((s) =>
            {
                return GetMapper();
            });

            return services;
        }

        private static IServiceCollection AddEntity(this IServiceCollection services)
        {
            services.AddDbContext<PedidosDbContext>();
            services.AddTransient<IGlobalDbTransaction, GlobalDbTransaction<PedidosDbContext>>();
            services.AddTransient<IDbContextFactory, GlobalDbTransaction<PedidosDbContext>>();
            services.AddTransient(typeof(IEntityRepository<,>), typeof(EntityRepository<,>));

            return services;
        }

        private static IMapper GetMapper()
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DashboardMapperProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();

            return mapper;
        }
    }
}