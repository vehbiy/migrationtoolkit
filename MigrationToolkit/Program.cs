using System;
using ToolBox.Bridge;

namespace MigrationToolkit
{
    class Program
    {
        public static IMigrationTools _migrationTools = new MigrationTools();
        private static IShellHelper _shellHelper = new ShellHelper();

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: gr [options]");
                Console.WriteLine("Options:");
                Console.WriteLine("\tmigrate");
                Console.WriteLine("\tmigrateandupdatedatabase");
                return;
            }

            switch (args[0])
            {
                case "migrate":
                    var migrationName1 = _migrationTools.CreateAndCopyMigrationName(false);
                    Response result1 = _shellHelper.RunInternalCommand(migrationName1);
                    Console.WriteLine(result1);
                    break;
                case "migrateandupdatedatabase":
                    var migrationName2 = _migrationTools.CreateAndCopyMigrationName(true);
                    Response result2 = _shellHelper.RunInternalCommand(migrationName2);
                    Console.WriteLine(result2);
                    break;
                case "name":
                    var migrationName3 = _migrationTools.CreateAndCopyMigrationName(false);
                    Console.WriteLine(migrationName3);
                    break;
                default:
                    break;
            }
        }
    }
}
