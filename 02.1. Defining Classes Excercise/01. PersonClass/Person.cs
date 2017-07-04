public class Person
{
    public Person() : this("No name", 1)
    { }
    public Person(int age) : this("No name", age)
    {
        this.age = age;
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public string name;
    public int age;

    public override string ToString()
    {
        return $"{this.name} - {this.age}";
    }
}