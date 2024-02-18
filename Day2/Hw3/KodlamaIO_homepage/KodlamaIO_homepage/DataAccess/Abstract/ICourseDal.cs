using KodlamaIO_homepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_homepage.DataAccess.Abstract
{
    public interface ICourseDal
    {
        void Add(Course course);
        void Delete(Course course);

        List<Course> GetAll();
        Course GetCourseById(int id);

    }
}
