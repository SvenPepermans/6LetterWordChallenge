using _6LetterWordChallenge.Services;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Reflection;

namespace _6LetterWordChallenge
{
    class Program
    {
        

        static async Task Main(string[] args)
        {
            var workingDir = Environment.CurrentDirectory;
            var projectDir = Directory.GetParent(workingDir).Parent.Parent.FullName;
            var filePlace = projectDir + @"\Data\input.txt";
           // var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), filePlace);
           
            Startup.RegisterServices();
            var readFileService = Startup.ServiceProvider.GetService<IReadFileService>();
            var combinationService = Startup.ServiceProvider.GetService<ICombinationService>();
            if (File.Exists(filePlace))
            {
                var words = await readFileService.ReadWordsFromFile(filePlace);
                combinationService.CombineWords(words);
                
            }
            else
            {
                Console.WriteLine("File does not exist");
            }

        }      
    }
}
