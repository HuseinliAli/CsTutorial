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
            var result = Sum(10,20,30,40,50,60,70,70,80,80,80);
            
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

        static int Sum(params int[] x)
        {
            var sum = 0;

            foreach (var y in x)
            {
                sum+=y;
            }
            return sum;
        }
    }
}
