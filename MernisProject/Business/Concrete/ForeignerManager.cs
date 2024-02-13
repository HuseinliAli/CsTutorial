using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ForeignerManager : IApplicantService<Foreigner>
{
    public void ApplyForMask(Foreigner person)
    {
        throw new NotImplementedException();
    }

    public bool CheckPerson(Foreigner person)
    {
        throw new NotImplementedException();
    }

    public List<Foreigner> GetList()
    {
        throw new NotImplementedException();
    }
}

