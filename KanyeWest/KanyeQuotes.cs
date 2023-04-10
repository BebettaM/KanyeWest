using System;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
	public class KanyeQuotes
	{
		public KanyeQuotes()
		{
		}

		public static void QuotesByKanye()
		{
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"Kanye: '{kanyeQuote}'");
        }

		public static void QuotesByRon()
		{
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"Ron: '{ronQuote}'");
        }
	}
}

