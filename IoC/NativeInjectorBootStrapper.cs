using Application.Dictionary;
using Domain.Handlers;
using Domain.Helpers;
using Domain.Repositories;
using Infrastructure.Repositories;


using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {

            #region Repositories
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<IVersionRepository, VersionRepository>();
            services.AddScoped<IEnvironmentRepository, EnvironmentRepository>();
            services.AddScoped<IApplicationRepository, ApplicationRepository>();
            #endregion

            #region Handlers
            services.AddTransient<TaskHandler>();
            services.AddTransient<VersionHandler>();
            services.AddTransient<EnvironmentHandler>();
            services.AddTransient<ApplicationHandler>();
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