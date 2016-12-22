using DbUp;
using System;
using System.Reflection;
using System.Linq;
namespace DbMigration
{
    class Program
    {
        static int Main(string[] args)
        {
            var connectionString =
        args.FirstOrDefault()
        ?? "Server=NOI-SANJAY-W81; Database=TestMigrate; Trusted_connection=true";

            //If you want your application to create the database for you, add the following line after the connection string:
            //  EnsureDatabase.For.SqlDatabase(connectionString);

            var upgrader =
                DeployChanges.To
                    .SqlDatabase(connectionString)
                    .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                    .LogToConsole()
                    .Build();

            var result = upgrader.PerformUpgrade();

            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
#if DEBUG
                Console.ReadLine();
#endif
                return -1;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success!");
            Console.ResetColor();
            return 0;
        }
    }
}
