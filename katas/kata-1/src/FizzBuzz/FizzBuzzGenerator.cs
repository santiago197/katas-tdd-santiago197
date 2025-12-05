namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            var result = new List<string>();
            if (count == 1)
                result.Add("1");
            if (count == 2)
            {
                result.Add("1");
                result.Add("2");
            }

            return result;
        }
    }
}