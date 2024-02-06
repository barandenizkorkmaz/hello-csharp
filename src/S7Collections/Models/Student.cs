namespace S7Collections.Models;

public class Student
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public float GPA { get; set; }

    public Student(int id, string name, float GPA)
    {
        this.Id = id;
        this.Name = name;
        this.GPA = GPA;
    }
}