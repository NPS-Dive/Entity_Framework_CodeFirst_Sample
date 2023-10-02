
using System.Collections;
using System.Collections.Generic;

public class Course
    {
    public int CourseID { get; set; }
    public string CourseTitle { get; set; }
    public byte CourseUnits { get; set; }

    public virtual ICollection<CourseSelect> CourseSelects { get; set; }
    }

