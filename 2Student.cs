using System;
public class Student
{
    private string name = string.Empty;
    private int rollNo;

    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                name = value;
            else
                throw new ArgumentException("Name cannot be empty");
        }
    }

    public int RollNo
    {
        get { return rollNo; }
        set
        {
            if (value >= 0)
                rollNo = value;
            else
                throw new ArgumentException("Roll number cannot be negative");
        }
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Student Name: {Name}, Roll No: {RollNo}");
    }
}
