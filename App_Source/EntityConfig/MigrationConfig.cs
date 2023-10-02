
using System.Data.Entity.Migrations;

public class MigrationConfig : DbMigrationsConfiguration<UniversityContext>
    {
    public MigrationConfig()
        {
        AutomaticMigrationsEnabled = true;
        AutomaticMigrationDataLossAllowed = true;
        }
    }

