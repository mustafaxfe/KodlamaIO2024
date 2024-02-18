using KodlamaIO_homepage.DataAccess.Abstract;
using KodlamaIO_homepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_homepage.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        private readonly List<Course>? courses;
        ﻿using kodlama.io_page.DataAccess.Abstracts;
using kodlama.io_page.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io_page.DataAccess.Concretes;

    public class CourseDal : ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {
            courses = new List<Course>();
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(Course course)
        {
            courses.Remove(course);
        }

        public List<Course> GetAll()
        {
            return courses; ;
        }


        public Course GetCourseById(int id)
        {
            return courses.Where(c => c.InstructorId == id).ToList();
        }
    }
}
