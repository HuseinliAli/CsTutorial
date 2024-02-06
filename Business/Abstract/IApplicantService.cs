using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;
public interface IApplicantService<T>
    where T : Person
{
    void ApplyForMask(T person);
    List<T> GetList();
    bool CheckPerson(T person);
}