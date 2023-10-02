using System.Data.Entity.ModelConfiguration;

public class CourseConfig : EntityTypeConfiguration<Course>
    {
    public CourseConfig ()
        {
        HasKey(c => c.CourseID);
        Property(c => c.CourseTitle).HasMaxLength(50).IsRequired();
        Property(c => c.CourseUnits).IsRequired();
        }
    }

