using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System.Collections.Generic;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {

        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _map;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper map)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _map = map;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            _bus.SendCommand(_map.Map<CreateCourseCommand>(courseViewModel));
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses()
                                    .ProjectTo<CourseViewModel>(_map.ConfigurationProvider);
        }
    }
}
