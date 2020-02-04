using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Info.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application layer
            #region ApplicationLayer
            services.AddScoped<ICourseService, CourseService>();

            #endregion

            //Infra.Data layer
            #region Infra.DataLayer
            services.AddScoped<ICourseRepository, CourseRepository>();

            #endregion
        }
    }
}
