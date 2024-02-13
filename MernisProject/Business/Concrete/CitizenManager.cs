using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System.Net.WebSockets;

namespace Business.Concrete;
public class CitizenManager : IApplicantService<Citizen>
{
    public void ApplyForMask(Citizen person)
    {
        throw new NotImplementedException();
    }

    public bool CheckPerson(Citizen person)
    {
        KPSPublicSoapClient client = new(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync(
                    person.NationalIdentityNumber,
                    person.Name,
                    person.LastName,
                    person.BirthYear).Result.Body.TCKimlikNoDogrulaResult;
    }

    public List<Citizen> GetList()
    {
        throw new NotImplementedException();
    }
}