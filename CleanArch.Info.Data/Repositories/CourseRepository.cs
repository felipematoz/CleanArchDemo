using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Info.Data.Context;
using System.Collections.Generic;

namespace CleanArch.Info.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _context;

        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
