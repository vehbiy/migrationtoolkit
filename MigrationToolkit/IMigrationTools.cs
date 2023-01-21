namespace MigrationToolkit
{
    public interface IMigrationTools
    {
        void CreateMigration();
        string CreateAndCopyMigrationName(bool updateDatabase);
        string CreateMigrationName();
    }
}
