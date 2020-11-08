using System;
using System.IO;
using System.Linq;

namespace OtusAlgorithms
{
    public class Program
    {
        private const string DirPath = "../../../../";

        private static void Main(string[] args)
        {
            Check($"{DirPath}0.String", new Strings());
            Check($"{DirPath}1.Tickets", new Tickets());
            Console.ReadKey();
        }

        private static void Check(string path, IAlgorithm algorithm)
        {
            var files = Directory.GetFiles(path);
            var inFiles = files.Where(x => x.Split('.').Last() == "in").ToArray();
            var outFiles = files.Where(x => x.Split('.').Last() == "out").ToArray();
            Console.WriteLine(algorithm.Name);
            
            for (int i = 0; i < inFiles.Length; i++)
            {
                var data = File.ReadAllText(inFiles[i]).Trim();
                var expected = File.ReadAllText(outFiles[i]).Trim();
                var actual = algorithm.Execute(data);
                Console.WriteLine($"{i + 1}. {actual == expected}");
            }

            Console.WriteLine("-----------------------------------\n");
        }
    }
}
