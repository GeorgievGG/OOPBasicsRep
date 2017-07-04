public class Company
{
    public Company(string name, string department, double salary)
    {
        this.Name = name;
        this.Department = department;
        this.Salary = salary;
    }

    private string name;
    private string department;
    private double salary;

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            this.name = value;
        }
    }

    public string Department
    {
        get
        {
            return this.department;
        }

        set
        {
            this.department = value;
        }
    }

    public double Salary
    {
        get
        {
            return this.salary;
        }

        set
        {
            this.salary = value;
        }
    }
    public override string ToString()
    {
        return $"{Name} {Department} {Salary:f2}";
    }
}