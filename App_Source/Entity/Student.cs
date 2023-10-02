using System.Collections.Generic;

public class Student
    {
    public long StudentID { get; set; }
    public string StuName { get; set; }
    public string StuFamily { get; set; }
    public byte Age { get; set; }

    public virtual ICollection<CourseSelect> CourseSelect { get; set; }

    }

