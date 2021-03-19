using _6LetterWordChallenge.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace _6LetterWordChallenge
{
    public static class Startup
    {
        public static IServiceProvider ServiceProvider;

        static Startup()
        {
            
        }

        public static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<ICombinationService, CombinationService>();
            services.AddScoped<IReadFileService, ReadFileService>();
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
