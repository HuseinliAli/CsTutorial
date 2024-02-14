using OOP.Interfaces;
using OOP.Intro;
using OOP.WorkingWithProperties;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager cm = new();
            cm.Add();
            cm.Updated();

            ProductManager pm = new();
            pm.Add();
            pm.Updated();

            Customer c1 = new()
            {
                City="Izmir",
                FirstName="Derin",
                LastName="Demir",
                Id=1
            };
            Console.WriteLine(c1.FirstName);
            IPerson[] persons = new IPerson[]
            {
                new Teacher{Id=1,LastName="Aliyev",FirstName="Huseyn",Subject="Math"},
                new Teacher{Id=2,LastName="Aliyev",FirstName="Huseyn",Subject="Math"},
                new Teacher{Id=3,LastName="Aliyev",FirstName="Huseyn",Subject="Math"},
                new Student{Id=4,LastName="Aliyev",FirstName="Huseyn",GPA=90.46m},
                new Student{Id=5,LastName="Aliyev",FirstName="Huseyn",GPA=90.46m},
                new Student{Id=6,LastName="Aliyev",FirstName="Huseyn",GPA=90.46m},
                new Student{Id=7,LastName="Aliyev",FirstName="Huseyn",GPA=90.46m}
            };

            foreach (var person in persons)
            {
                if(person.GetType() == typeof(Teacher))
                {
                    Teacher teacher = (Teacher)person;
                    Console.WriteLine($"{teacher.Id} {teacher.FirstName} {teacher.LastName} {teacher.Subject}");
                }else if(person.GetType() == typeof(Student))
                {
                    Student student = (Student)person;
                    Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName} {student.GPA}");
                }
            }
        }
    }
}
