﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctoberCourses.Repositories
{
    public interface IRepository<T> where T :class
    {
        IEnumerable<T> GetAll();

        T GetById(int id);
    }
}
