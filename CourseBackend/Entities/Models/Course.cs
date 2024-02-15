using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models;
public class Course:BaseEntity<int>
{
    public string ImagePath { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public Guid InstructorId { get; set; }
    public Instructor Instructor { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }
}