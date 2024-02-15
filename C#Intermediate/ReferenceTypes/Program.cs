namespace ReferenceTypes;
internal class Program
{
    static void Main(string[] args)
    {
        //Dəyər tipli dəyişənlər stack-də yaranır.
        int num1 = 10;
        int num2 = 20;

        num1 = num2;
        num2 = 100;

        Console.WriteLine(num1);


        //stack yenə var. dəyər tiplilər stack istifadə edir.
        //referans tiplər üçün heap-də yer ayrılır.
        //nums1 stack-də [10, 20, 30] yaradır
        int[] nums1 = [10, 20, 30];
        int[] nums2 = [30, 20, 10];
        nums1 = nums2;
        nums2[0] = 1000;
        Console.WriteLine(nums1[0]);

        Person p1 = new()
        {
            Id = 1,
            FirstName = "Ali"
        };

        Person p2 = new()
        {
            Id = 2,
            FirstName = "Huseyn"
        };
        p1 = p2;
        p2.FirstName = "X";

        Console.WriteLine(p1.FirstName);

        Person c1 = new Customer()
        {
            Id=3,
            FirstName="Nihat",
            CreditCardnumber="1234-5678-9098-7654"
        };

        Person e1 = new Employee()
        {
            Id=4,
            FirstName="Tuqay",
            Number=30303030
        };

        Person[] ps = [c1,e1];
        foreach (var person in ps)
        {
            Console.WriteLine(person.FirstName);
        }
        var manager = new PersonManager();
        manager.Add(p1);
        manager.Add(c1);
        manager.Add(e1);
    }
}

