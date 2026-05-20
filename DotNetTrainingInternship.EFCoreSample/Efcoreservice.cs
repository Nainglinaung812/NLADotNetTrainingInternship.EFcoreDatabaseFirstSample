
using DTO.AppDbContextModels;
public class Efcoreservice
{
    private readonly AppDbContext _db;

    public Efcoreservice()
    {
        _db = new AppDbContext();
    }
    public void Read()
    {
        List<Student> students = _db.Students.ToList();
        foreach (Student student in students)
        {
            Console.WriteLine($"Id: {student.StudentId}, Name: {student.StudentName}, Age: {student.Age}, Gender: {student.Gender}");
        }
    }
    public void Edit()
    {
        var item = _db.Students.FirstOrDefault(s => s.StudentId == 1);
        if (item is null)
        {
            return;
        }
        item.Gender = "Female";
        item.StudentName = "Phyo";
        item.Age = 29;
        int result = _db.SaveChanges();
        string response = result > 0 ? "Edit Success" : "Edit Failed";
        Console.WriteLine(response);
    }
    public void Create()
    {
        Student student = new Student()
        {
            StudentName = "Aye Han",
            Age = 23,
            Gender = "Female"
        };
        _db.Students.Add(student);
        int result = _db.SaveChanges();
        string response = result > 0 ? "Create Success" : "Create Failed";
        Console.WriteLine(response);

    }
    public void Delete()
    {
        Student item = _db.Students.FirstOrDefault(x => x.StudentId == 1);
        if(item is null)
        {
            return;
        }
        _db.Students.Remove(item);
        int result = _db.SaveChanges();
        string response = result > 0 ? "Delete Success" : "Delete Failed";
        Console.WriteLine(response);
    }





}