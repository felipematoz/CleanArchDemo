using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Commands;
using CleanArch.Domain.CommandsHandler;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Info.Data.Context;
using CleanArch.Info.Data.Repositories;
using CleanArch.Infra.Bus;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBus MediatR
            #region MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();
            #endregion

            //Domain Handlers
            #region Handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CouseCommandHandler>();
            #endregion

            //Application layer
            #region ApplicationLayer
            services.AddScoped<ICourseService, CourseService>();
            #endregion

            //Infra.Data layer
            #region Infra.DataLayer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDbContext>();
            #endregion
        }
    }
}
