namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = @"migrationFile.txt";
            var dbMigrator  = new DataBaseMigrate(new ConsoleLogger());
            dbMigrator.Migrate();
            var dbMigratorToFile = new DataBaseMigrate(new FileLogger(fileName));
            dbMigratorToFile.Migrate();
        }
    }
}
