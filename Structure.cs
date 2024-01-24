using System;
struct Employee
{
    public int empid;
    public string empname;
    public double empsalary;
    public string empdepartment;

    public Employee(int id, string name, double salary, string department)
    {
        empid = id;
        empname = name;
        empsalary = salary;
        empdepartment = department;
    }

    public void employeedetails()
    {
        Console.WriteLine($"id is {empid}");
        Console.WriteLine($"Name is {empname}");
        Console.WriteLine($"Department is {empdepartment}");
        Console.WriteLine($"Salary is {empsalary}");

    }
}
class Structure
{
    static void Main()  
    {
        Employee employee = new Employee(1, "Priyansh", 5000000, "FullStack Developer");
        employee.employeedetails();
    }
}