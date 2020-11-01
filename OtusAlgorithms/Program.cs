using System;
using System.IO;
using System.Linq;

namespace OtusAlgorithms
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var stringPath = "../../../../0.String";
            var ticketsPath = "../../../../1.Tickets";
            Check(stringPath, new Strings());
            Check(ticketsPath, new Tickets());
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
