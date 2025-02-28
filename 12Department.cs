using System;

public class Manager
{
    public string Name { get; set; }

    public Manager(string name)
    {
        Name = name;
    }
}

public class Department
{
    public string DeptName { get; set; }
    public Manager Manager { get; set; }

    public Department(string deptName, string managerName)
    {
        DeptName = deptName;
        Manager = new Manager(managerName);
    }
    public Department ShallowCopy()
    {
        return (Department)this.MemberwiseClone();
    }
    public Department DeepCopy()
    {
        return new Department(this.DeptName, this.Manager.Name);
    }
}

