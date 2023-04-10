using Newtonsoft.Json.Linq;

namespace KanyeWest;
class Program
{
    static void Main(string[] args)
    {


        bool cont = true;

        do
        {
            KanyeQuotes.QuotesByKanye();

            KanyeQuotes.QuotesByRon();
            Console.WriteLine("Continue? Y or N?");

            var response = Console.ReadLine().ToLower();

            cont = (response == "n") ? false : true;

        } while (cont);

    }

    

    
}

