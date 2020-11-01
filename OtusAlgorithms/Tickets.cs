namespace OtusAlgorithms
{
    public class Tickets : IAlgorithm
    {
        public string Name { get; } = "Tickets";

        private static int count;

        public string Execute(string input)
        {
            count = 0;
            Calc(int.Parse(input) * 2, 0, 0, 0);
            return count.ToString();
        }

        private void Calc(int n, int current, int sum1, int sum2)
        {
            if (current == n)
            {
                if (sum1 == sum2)
                    count++;
                return;
            }

            if (current < n / 2)
            {
                for (int i = 0; i < 10; i++)
                    Calc(n, current + 1, sum1 + i, sum2);
            }
            else
            {
                for (int i = 0; i < 10; i++)
                    Calc(n, current + 1, sum1, sum2 + i);
            }
        }
    }
}
