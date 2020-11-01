namespace OtusAlgorithms
{
    public class Strings : IAlgorithm
    {
        public string Name { get; } = "Strings";

        public string Execute(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                count++;
            }

            return count.ToString();
        }
    }
}
