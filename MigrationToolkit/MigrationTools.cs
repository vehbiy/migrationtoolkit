using System;
using TextCopy;

namespace MigrationToolkit
{
    public class MigrationTools : IMigrationTools
    {
        public void CreateMigration()
        {
            var migrationName = "Migrations_" + Guid.NewGuid().ToString().Replace("-", "").Substring(0, 5);
            Console.WriteLine(migrationName);
            Clipboard clipboard = new();
            clipboard.SetText("add-migration " + migrationName + ";update-database");
        }

        public string CreateMigrationName()
        {
            var migrationName = "Migrations_" + Guid.NewGuid().ToString().Replace("-", "").Substring(0, 5);
            return migrationName;
        }

        public string CreateAndCopyMigrationName(bool updateDatabase)
        {
            var migrationName = CreateMigrationName();
            var text = "add-migration " + migrationName;

            if (updateDatabase)
            {
                text += ";update-database";
            }

            Console.WriteLine(text);
            Clipboard clipboard = new();
            clipboard.SetText(text);
            return text;
        }
    }
}
