namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            //var result = Sum(10);
            int x;
            int y = 20;
            //var result = Sum(ref x, y);
            var result = Sum(out x, y);
            Console.WriteLine(x);
            Console.WriteLine(result);
        }
        static void Add()
        {
            Console.WriteLine("Added");
        }
        //static int Sum(int x, int y = 10)
        //{
        //    return x+y;
        //}
        static int Sum(out int x, int y)
        {
            x=30;
            return x+y;
        }
    }
}
