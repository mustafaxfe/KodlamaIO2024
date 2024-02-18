using KodlamaIO_homepage.Business.Abstract;
using KodlamaIO_homepage.DataAccess.Abstract;
using KodlamaIO_homepage.DataAccess.Concrete;
using KodlamaIO_homepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_homepage.Business.Concrete;

public class CategoryManager : ICategoryService
{
    public ICategoryDal? _categoryDal;
    private CategoryDal categoryDal;

    public CategoryManager(CategoryDal categoryDal)
    {
        this.categoryDal = categoryDal;
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public Category GetById(int id)
    {
        return _categoryDal.GetById(id);
    }

    public void Remove(Category category)
    {
        _categoryDal.Delete(category);
    }
}
