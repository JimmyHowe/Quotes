using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace Quotes
{
    internal class Program
    {
        private static readonly List<Quote> Quotes = new List<Quote>();

        private static void Main(string[] args)
        {
            GenerateQuotes();

            OutputHeader();

            if (args.Contains("--all"))
            {
                DumpQuotes();

                return;
            }

            var quote = GetRandomQuote();

            Console.WriteLine(quote + "\n");
        }

        /// <summary>
        ///     Gets a random wuote from the collection
        /// </summary>
        /// <returns>A random quote object</returns>
        private static Quote GetRandomQuote()
        {
            var random = new Random();

            return Quotes[random.Next(Quotes.Count)];
        }

        /// <summary>
        ///     Dumps the quotes to the console
        /// </summary>
        private static void DumpQuotes()
        {
            foreach (var quote in Quotes) Console.WriteLine(quote + "\n");
        }

        /// <summary>
        ///     Outputs the application header to console
        /// </summary>
        private static void OutputHeader()
        {
            var title = "Quotes.exe - (" + Quotes.Count + ") quote(s)";
            var banner = new string('=', title.Length);
            Console.WriteLine(banner + "\n" + title + "\n" + banner + "\n");
        }

        /// <summary>
        ///     Builds up the quotes collection
        /// </summary>
        private static void GenerateQuotes()
        {
            Quotes.Add(new Quote("Jimmy Howe", "Programming is easy!!!"));
            Quotes.Add(new Quote("Seneca", "We suffer more often in imagination than in reality."));
            Quotes.Add(new Quote("Marcus Aurelius",
                "You could leave life right now. Let that determine what you do and say and think."));
            Quotes.Add(new Quote("Epictetus", "Some things are in our control and others not."));
        }
    }
}