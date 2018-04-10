namespace Quotes
{
    internal class Quote
    {
        private readonly string _author;
        private readonly string _quote;

        public Quote(string author, string quote)
        {
            _author = author;
            _quote = quote;
        }

        public override string ToString()
        {
            string quote = _quote + " -- " + _author;

            return quote;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public string GetQuote()
        {
            return _quote;
        }
    }
}