using KodlamaIO_homepage.DataAccess.Abstract;
using KodlamaIO_homepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_homepage.DataAccess.Concrete;

public class CategoryDal : ICategoryDal
{
    List<Category> _categories;
    public CategoryDal() {
        _categories = new List<Category>();
    }

    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Delete(Category category)
    {
        _categories.Remove(category);
    }

    public void DeleteById(int id)
    {
        _categories.Remove(_categories.Single(c => c.CategoryId == id));
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public Category GetById(int id)
    {
        return _categories.Single(c => c.CategoryId == id);
    }

    public void Insert(Category category)
    {
        _categories.Add(category);
    }

    public void Update(ref Category category)
    {
        for(int i = 0; i<_categories.Count; i++)
            _categories[i].CategoryName = category.CategoryName;
    }

    public void Update(Category category)
    {
        throw new NotImplementedException();
    }
}
