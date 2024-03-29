﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OctoberCourses.Data;
using OctoberCourses.Models;

namespace OctoberCourses.Repositories
{
    public class InstructorRepository : IRepository<Instructor>
    {
        private UniversityContext db;

        public InstructorRepository(UniversityContext db)
        {
            this.db = db;
        }

        public void Create(Instructor instructor)
        {
            db.Instructors.Add(instructor);
            db.SaveChanges();
        }

        public IEnumerable<Instructor> GetAll()
        {
            return db.Instructors.ToList();
        }

        public Instructor GetById(int id)
        {
            return db.Instructors.Single(c => c.Id == id);
        }
    }
}
