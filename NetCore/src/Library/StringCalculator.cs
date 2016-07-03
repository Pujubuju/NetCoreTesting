namespace Library
{
    public class StringCalculator
    {
        private static int Parse(string number)
        {
            return int.Parse(number);
        }

        public int Add(string x, string y)
        {
            return Parse(x) + Parse(y);
        }

        public bool IsOdd(string value)
        {
            return Parse(value) % 2 == 1;
        }
    }
}
