namespace _2.Advertisement_Message
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class Advertisement_Message
    {
        public static void Main(string[] args)
        {
            int numberMessages = int.Parse(Console.ReadLine());
            string[] phrases = new[]
            {
                "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };
            string[] events = new[]
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
            string[] autor = new[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            string[] city = new[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            var randMessage = new Random();

            for (int i = 0; i <= numberMessages; i++)
            {
                string currentPhrase = phrases[randMessage.Next(0, phrases.Length - 1)];
                string currentEvent = events[randMessage.Next(0, events.Length - 1)];
                string currentAutor = autor[randMessage.Next(0, autor.Length - 1)];
                string currentCity = city[randMessage.Next(0, city.Length - 1)];
                Console.WriteLine($"{currentPhrase} {currentEvent} {currentAutor} – {currentCity}.");
            }

        }
    }
}