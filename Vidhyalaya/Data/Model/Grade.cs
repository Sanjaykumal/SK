using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class Grade
{
    public int Label {get ; set ;}
    public string ClassTeacher{get ; set ;}
    public string Medium {get ; set ;}
    public string Subjects {get ; set ;}
    public DateTime SessionYear {get ; set ;}
    public List<Student> Students { get; set; }

}