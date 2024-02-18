using KodlamaIO_homepage.DataAccess.Abstract;
using KodlamaIO_homepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_homepage.DataAccess.Concrete;

//public class CourseDal : ICourseDal
//{
//    private readonly List<Course>? courses;

//}
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
        return courses.SingleOrDefault(c => c.CourseId == id);
    }

}
