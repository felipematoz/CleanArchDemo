using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Info.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace CleanArch.Info.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _context;

        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public IQueryable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
