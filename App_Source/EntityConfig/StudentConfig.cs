using System.Data.Entity.ModelConfiguration;

public class StudentConfig : EntityTypeConfiguration<Student>
    {
    public StudentConfig ()
        {

        HasKey(st => st.StudentID);
        Property(st => st.StuName).HasMaxLength(50).IsRequired();
        Property(st => st.StuFamily).HasMaxLength(50).IsRequired();
        }
    }

