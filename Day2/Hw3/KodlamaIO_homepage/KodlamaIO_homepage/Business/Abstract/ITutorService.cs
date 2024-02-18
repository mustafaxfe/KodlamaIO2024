using KodlamaIO_homepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_homepage.Business.Abstract;

public interface ITutorService
{
    Tutor GetById(int id);
    void Add(Tutor tutor);
    void Delete(Tutor tutor);
    void Update(Tutor tutor);
    List<Tutor> GetAll();
 }
