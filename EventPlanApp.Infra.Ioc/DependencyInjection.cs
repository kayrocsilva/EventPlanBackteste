using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EventPlanApp.Infra.Data.Context;
using EventPlanApp.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventPlanApp.Domain.Interfaces;

namespace EventPlanApp.Infra.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EventPlanContext>(options =>
                options.UseSqlServer(connectionString));

            // Registrando repositórios
            services.AddScoped<IUsuarioFinalRepository, UsuarioFinalRepository>();
            services.AddScoped<IEventoRepository, EventoRepository>();
            services.AddScoped<IIngressoRepository, IngressoRepository>();
            services.AddScoped<IOrganizacaoRepository, OrganizacaoRepository>();
            services.AddScoped<IUsuarioAdmRepository, UsuarioAdmRepository>();

            return services;
        }
    }
}
