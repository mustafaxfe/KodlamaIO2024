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

public class TutorManager : ITutorService
{
    public readonly ITutorDal _tutorDal;
    //private TutorDal tutorDal = tutorDal;
    public TutorManager(ITutorDal tutorDal)
    {
        _tutorDal = tutorDal;
    }
    public void Add(Tutor tutor)
    {
        _tutorDal.Add(tutor);
    }

    public void Delete(Tutor tutor)
    {
        _tutorDal.Delete(tutor);
    }

    public void DeleteAll()
    {
    }
    public List<Tutor> GetAll()
    {
        return _tutorDal.GetAll();
    }
    public Tutor GetById(int id)
    {
        return _tutorDal.GetById(id);
    }

    public void Update(Tutor tutor)
    {
        throw new NotImplementedException();
    }
}
