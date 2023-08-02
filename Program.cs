namespace Class5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new string[] { "flower", "axe", "mango", "owl", "yak" };
            var result = words.Where(  element => element.Contains("a"));

            foreach(var item in result)
            {
                Console.WriteLine(item);    
            }
        }
    }
}