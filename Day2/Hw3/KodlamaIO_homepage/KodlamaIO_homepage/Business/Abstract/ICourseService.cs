using KodlamaIO_homepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_homepage.Business.Abstract;

public interface ICourseService
{
    void Add(Course course);
    void Delete(Course course);
    Course GetById(int id);
    List<Course> GetAll();

}
