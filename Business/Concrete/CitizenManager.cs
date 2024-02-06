using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;
public class CitizenManager : IApplicantService
{

    public void ApplyForMask(Citizen citizen)
    {
    }

    public List<Citizen> GetList()
    {
        return null;
    }

    public bool CheckPerson(Citizen citizen)
    {
        return true;
    }
}

public class ForeignerManager : IApplicantService
{
    public void ApplyForMask(Citizen citizen)
    {
        throw new NotImplementedException();
    }

    public bool CheckPerson(Citizen citizen)
    {
        throw new NotImplementedException();
    }

    public List<Citizen> GetList()
    {
        throw new NotImplementedException();
    }
}

public class PttManager(IApplicantService applicantService)
{
    public void GiveMask(Citizen citizen)
    {
        if (applicantService.CheckPerson(citizen))
        {
            Console.WriteLine(citizen.Name);
        }
    }
}