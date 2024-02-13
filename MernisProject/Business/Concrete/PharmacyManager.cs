using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class PharmacyManager<T>(IApplicantService<T> applicantService) : ISupplierService<T>
    where T:Person
{
    public void GiveMask(T person)
    {
        if (applicantService.CheckPerson(person))
        {
            Console.WriteLine($"{person.Name} {person.LastName} was given a mask");
        }
        else
        {
            Console.WriteLine($"{person.Name} {person.LastName} was not given a mask");
        }
    }
}

