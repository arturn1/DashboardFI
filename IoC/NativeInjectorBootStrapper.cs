using Application.Dictionary;
using Domain.Handlers;
using Domain.Helpers;
using Domain.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories;


using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {

            #region Repositories
            services.AddScoped<IVersionRepository, VersionRepository>();
            services.AddScoped<ITasksRepository, TasksRepository>();
            services.AddScoped<IEnvironmentRepository, EnvironmentRepository>();
            services.AddScoped<IApplicationsRepository, ApplicationsRepository>();
            #endregion

            #region Handlers
            services.AddTransient<VersionHandler>();
            services.AddTransient<TasksHandler>();
            services.AddTransient<EnvironmentHandler>();
            services.AddTransient<ApplicationsHandler>();
            #endregion

            #region Services
            #endregion

            #region Dictionary
            services.AddSingleton<DefaultDictionary>();
            #endregion

            #region Helper
            services.AddScoped<IMapper, Mapper>();
            #endregion

        }
    }
}