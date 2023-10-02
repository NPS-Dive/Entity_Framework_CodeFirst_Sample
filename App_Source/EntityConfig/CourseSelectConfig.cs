using System.Data.Entity.ModelConfiguration;

public class CourseSelectConfig : EntityTypeConfiguration<CourseSelect>
    {
    public CourseSelectConfig ()
        {
        HasKey(cs => cs.CoSelID);
        Property(cs => cs.CoSelDate).HasMaxLength(10).IsRequired();
        Property(cs => cs.CoSelScore).IsRequired();
        }
    }

