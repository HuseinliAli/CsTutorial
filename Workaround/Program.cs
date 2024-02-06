using Business.Concrete;
using Entities.Concrete;

var citizenManager = new PttManager<Citizen>(new CitizenManager());
citizenManager.GiveMask(new Citizen { Name="Ali", LastName="Huseynli", BirthYear=2004, NationalIdentityNumber=123 });