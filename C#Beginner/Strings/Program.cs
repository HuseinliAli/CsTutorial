namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Ali";
            Console.WriteLine(sentence.Length);
            Console.WriteLine(sentence.Replace('a','e'));
            Console.WriteLine(sentence.Clone());
            Console.WriteLine(sentence.EndsWith('i'));
            Console.WriteLine(sentence.StartsWith("My name"));
            Console.WriteLine(sentence.IndexOf("Ali"));
            Console.WriteLine(sentence.IndexOf(" "));
            Console.WriteLine(sentence.LastIndexOf(" "));
            Console.WriteLine(sentence.Insert(10," bla bla bla"));
            Console.WriteLine(sentence.Substring(10,2));
            Console.WriteLine(sentence.ToLower());
            Console.WriteLine(sentence.ToUpper());
            Console.WriteLine(sentence.Remove(10,2));
            Console.WriteLine(sentence.Split(" "));
            foreach (var word in sentence.Split(" "))
            {
                Console.WriteLine(word);
            }
        }

        private static void StringsPractise()
        {
            string city1 = "Ankara";

            foreach (var character in city1)
            {
                Console.WriteLine(character);
            }
            string city2 = "Istanbul";

            Console.WriteLine(string.Format("{0} {1}", city1, city2));
        }
    }
}
