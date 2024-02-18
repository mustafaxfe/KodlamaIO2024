using KodlamaIO_homepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_homepage.DataAccess.Abstract;

public interface ITutorDal
{
    List<Tutor> GetAll();
    void Add(Tutor tutor);
    void Remove(Tutor tutor);
    Tutor GetById(int id);
    void Delete(Tutor tutor);
    //void Update(Tutor tutor);
}
