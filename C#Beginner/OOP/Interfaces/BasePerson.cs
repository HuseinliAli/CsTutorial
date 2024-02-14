namespace OOP.Interfaces;

internal abstract class BasePerson : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
