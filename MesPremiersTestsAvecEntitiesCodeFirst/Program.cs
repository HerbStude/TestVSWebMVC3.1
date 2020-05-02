using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace MesPremiersTestsAvecEntitiesCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            ConfigurationBuilder builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();

            string conenctionString = config.GetConnectionString("DefaultContext");

            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();

            optionsBuilder.UseSqlServer(conenctionString);
            
            using (DefaultContext context = new DefaultContext(optionsBuilder.Options))
            {
                var query = from droid in context.Droids
                            select droid;

                foreach (var item in query.ToList())
                {
                    Console.WriteLine(item.Matricule);
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
