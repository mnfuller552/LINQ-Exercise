using System.Linq;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> Videogames = new List<string>() { "Super Mario Bros", "Zelda" };
            Videogames.Add("Call of Duty");
            Videogames.Add("Grand Theft Auto");

            var order = Videogames.OrderBy(name => name.Length);

            foreach (var videogame in order)
            {
                Console.WriteLine(videogame);
            }
        }
    }
}
