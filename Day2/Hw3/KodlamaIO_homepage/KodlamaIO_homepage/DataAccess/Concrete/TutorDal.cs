using KodlamaIO_homepage.DataAccess.Abstract;
using KodlamaIO_homepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_homepage.DataAccess.Concrete;

public class TutorDal : ITutorDal
{
    List<Tutor> tutors = new List<Tutor>();
    public void Add(Tutor tutor)
    {
        tutors.Add(tutor);
    }

    public void Delete(Tutor tutor)
    {
        tutors.Remove(tutor);

    }

    public List<Tutor> GetAll()
    {
        return tutors;
    }

    public Tutor GetById(int id)
    {
        return tutors.SingleOrDefault(i => i.TutorId == id);
    }

    public void Remove(Tutor tutor)
    {
        tutors.Remove(tutor);
    }
}
