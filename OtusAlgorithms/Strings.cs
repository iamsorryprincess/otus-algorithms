namespace OtusAlgorithms
{
    public class Strings : IAlgorithm
    {
        public string Name { get; } = "Strings";

        public string Execute(string input) => input.Length.ToString();
    }
}
