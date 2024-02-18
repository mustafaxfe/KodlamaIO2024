using KodlamaIO_homepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_homepage.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        void Insert(Category category);
        void Delete(Category category);
        void Update(Category category);
        void DeleteById(int id);
        Category GetById(int id);
        List<Category> GetAll();
        void Add(Category category);
    }
}
