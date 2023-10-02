
public class CourseSelect
    {
    public long CoSelID { get; set; }
    public string CoSelDate { get; set; }
    public decimal CoSelScore { get; set; }

    // --- make foreign keys  ---
    public virtual Student Student { get; set; }
    public virtual Course Course { get; set; }
    }

