
using System.Data.Entity;

public class UniversityContext : DbContext
    {
     static UniversityContext ()
        {
        //    Database.SetInitializer<UniversityContext>
        // (new DropCreateDatabaseIfModelChanges<UniversityContext>());
        Database.SetInitializer<UniversityContext>
            (new MigrateDatabaseToLatestVersion<UniversityContext,MigrationConfig>("DbConnection"));
        }
    public UniversityContext ()
        : base("name=DbConnection")
        {
        }
    protected override void OnModelCreating ( DbModelBuilder modelBuilder )
        {
        modelBuilder.Configurations.Add(new StudentConfig());
        modelBuilder.Configurations.Add(new CourseConfig());
        modelBuilder.Configurations.Add(new CourseSelectConfig());

        base.OnModelCreating(modelBuilder);
        }
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<Course> Courses { get; set; }
    public virtual DbSet<CourseSelect> CourseSelects { get; set; }
    }

