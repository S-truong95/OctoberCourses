using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OctoberCourses.Data;
using OctoberCourses.Models;

namespace OctoberCourses.Repositories
{
    public class CourseRepository : IRepository<Courses>
    {
        private UniversityContext db;

        public CourseRepository(UniversityContext db)
        {
            this.db = db;

        }

        public IEnumerable<Courses> GetAll()
        {
            return db.Courses;
        }

        public Courses GetById(int id)
        {
            return db.Courses.Single(c => c.Id == id);
        }
    }
}
