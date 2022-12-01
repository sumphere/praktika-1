namespace praktika_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"F(x) = x * ln(x) + 4sin(2x) - 2" +
                $"\nОтвет: {Dichotomy(1, 4)}");
        }
        static float Function(float x)
            => (float)(x * Math.Log(x) + 4 * Math.Sin(2 * x) - 2);
        static float Dichotomy(float min, float max)
        {
            var median = (min + max) / 2;
            while (Math.Abs(Function(median)) > 0.001)
            {
                Console.WriteLine(median);
                if (Function(median) * Function(min) > 0)
                    min = median;
                else
                    max = median;

                median = (min + max) / 2;
            }
            return median;
        }
    }
}