namespace ProjetoForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[]{"Maria", "Alex", "Bob"};

            foreach(string obj in vect)
            {
                System.Console.WriteLine(obj);
            }
        }
    }
}
