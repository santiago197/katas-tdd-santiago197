namespace FizzBuzz
{
    public static class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            var result = new List<string>();
            for (var numero = 1; numero <= count; numero++)
            {
                if (EsMultiploDe(numero, 15))
                {
                    result.Add("FizzBuzz");
                    break;
                }
                if (EsMultiploDe(numero, 3))
                    result.Add("Fizz");
                else if (EsMultiploDe(numero, 5))
                    result.Add("Buzz");
                else
                    result.Add(numero.ToString());
            }

            return result;
        }

        private static bool EsMultiploDe(int numero, int multiplo) => numero % multiplo == 0;
    }
}