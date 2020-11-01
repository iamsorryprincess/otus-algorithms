namespace OtusAlgorithms
{
    public interface IAlgorithm
    {
        string Name { get; }

        string Execute(string input);
    }
}
