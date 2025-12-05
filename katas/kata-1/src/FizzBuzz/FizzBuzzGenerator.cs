namespace FizzBuzz
{
    public static class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            var result = new List<string>();
            for (var number = 1; number <= count; number++)
            {
                if (EsMultiploDe15(number))
                {
                    result.Add("FizzBuzz");
                    continue;
                }

                if (IsMultipleOf(number, 3))
                    result.Add("Fizz");
                else if (IsMultipleOf(number, 5))
                    result.Add("Buzz");
                else
                    result.Add(number.ToString());
            }

            return result;
        }

        private static bool EsMultiploDe15(int number) => IsMultipleOf(number, 3) && IsMultipleOf(number, 5);

        private static bool IsMultipleOf(int number, int multiple) => number % multiple == 0;
    }
}