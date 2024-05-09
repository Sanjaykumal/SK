public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public Gender sex{get ; set;}
    public DateTime Dob { get; set; }
    public byte[] Photo {get ; set ;}
    public string Guardian_name { get; set; }
    public string Guardian_contact { get; set; }

    public int GradeLabel{ get; set; }
    public Grade Grade { get; set; }



}
public enum Gender
{
    Male,
    Female,
    Others
}