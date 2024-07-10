using System;
using System.Collections.Generic;
using System.Text;

// a. Tạo lớp trừu tượng Person
public abstract class Person
{
    public string Name { get; set; }
    public string Id { get; set; }
}

// b. Tạo interface Kpi
public interface Kpi
{
    float Kpi();
}

// c. Tạo lớp Student kế thừa Person, cài đặt Kpi
public class Student : Person, Kpi
{
    private string _department;
    public string Department
    {
        get { return _department; }
        set
        {
            if (value == "ICT" || value == "ECO")
                _department = value;
            else
                throw new ArgumentException("Department must be 'ICT' or 'ECO'.");
        }
    }

    public float Kpi()
    {
        // Thực hiện tính toán và trả về điểm GPA
        return 3.5f;
    }

    public bool IsIdValid()
    {
        return Id.Length == 8 && int.TryParse(Id, out _);
    }
}

class Program
{
    static void Main(string[] args)
    {Console.OutputEncoding = Encoding.UTF8;
        // d. Khai báo obs kiểu Person và gán null
        Person obs = null;

        // e. Cấp phát obs là Student
        obs = new Student
        {
            Name = "Nguyễn Tiến Dũng",
            Id = "12345678",
            Department = "ICT"
        };
        Console.WriteLine($"KPI: {((Student)obs).Kpi()}");

        // g. Cấp phát obs bị sai về id hoặc department
        try
        {
            obs = new Student
            {
                Name = "Nguyễn Văn Nam",
                Id = "1234567",
                Department = "MATH"
            };
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // h. Khai báo danh sách list1, list2 các đối tượng Person
        List<Person> list1 = new List<Person>();
        List<Person> list2 = new List<Person>();

        // Nhập vào từ bàn phím list1
        Console.WriteLine("Nhập danh sách sinh viên bàn 1 (kết thúc nhập khi nhập tên '#'):");
        while (true)
        {
            Console.Write("Nhập tên: ");
            string name = Console.ReadLine();
            if (name == "#") break;
            Console.Write("Nhập ID: ");
            string id = Console.ReadLine();
            list1.Add(new Student { Name = name, Id = id, Department = "ICT" });
        }

        // Nhập vào từ bàn phím list2
        Console.WriteLine("Nhập danh sách sinh viên bàn 2 (kết thúc nhập khi nhập tên '#'):");
        while (true)
        {
            Console.Write("Nhập tên: ");
            string name = Console.ReadLine();
            if (name == "#") break;
            Console.Write("Nhập ID: ");
            string id = Console.ReadLine();
            list2.Add(new Student { Name = name, Id = id, Department = "ECO" });
        }

        // Hiển thị list1, list2
        Console.WriteLine("Danh sách sinh viên bàn 1:");
        foreach (var student in list1)
            Console.WriteLine($"Name: {student.Name}, ID: {student.Id}, Department: {((Student)student).Department}");

        Console.WriteLine("Danh sách sinh viên bàn 2:");
        foreach (var student in list2)
            Console.WriteLine($"Name: {student.Name}, ID: {student.Id}, Department: {((Student)student).Department}");

        // k. Khai báo list_list và bổ sung list1, list2
        List<List<Person>> list_list = new List<List<Person>>();
        list_list.Add(list1);
        list_list.Add(list2);

        // Hiển thị list_list
        Console.WriteLine("Danh sách các danh sách sinh viên:");
        foreach (var studentList in list_list)
        {
            foreach (var student in studentList)
                Console.WriteLine($"Name: {student.Name}, ID: {student.Id}, Department: {((Student)student).Department}");
            Console.WriteLine();
        }

        // l. Tạo dictionary dic11 cho list1, tìm sinh viên tên "Nam"
        Dictionary<string, Student> dic11 = new Dictionary<string, Student>();
        foreach (var student in list1)
        {
            if (student is Student s && s.IsIdValid())
            {
                dic11[s.Id] = s;
            }
        }

        Console.WriteLine("Sinh viên có tên 'Nam' trong list1:");
        foreach (var student in dic11.Values)
        {
            if (student.Name.Contains("Nam"))
                Console.WriteLine($"Name: {student.Name}, ID: {student.Id}, Department: {student.Department}");
        }
    }
}