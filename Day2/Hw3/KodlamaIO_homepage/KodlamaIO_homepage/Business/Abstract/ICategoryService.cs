using KodlamaIO_homepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_homepage.Business.Abstract;

public interface ICategoryService
{
    List<Category> GetAll();
    void Add(Category category);
    void Remove(Category category);
    Category GetById(int id);


}
