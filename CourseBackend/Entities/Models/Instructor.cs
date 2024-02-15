namespace Entities.Models;

public class Instructor:BaseEntity<Guid>
{
    public string ImagePath { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }
}