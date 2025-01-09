namespace coffee_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Coffee = new List<string>();
            string names;

            Console.WriteLine("please enter 5 coffee names");
            for (int i = 0; i < 5; i++)
            {
                names = Console.ReadLine();
                Coffee.Add(names);
            }
            Console.WriteLine("here are your coffee names");
            for (int i = 0;i < 5; i++)
            {
                Console.WriteLine(i+1+"-"+Coffee[i]);
            }
        }
    }
}
