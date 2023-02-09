using System;

class Student
{
    public string name = "Name";
    public string lastname = "Boichuk";
    public int age = 18;


    public void Print()
    {
       Console.WriteLine($"Name: {name} Lastname: {lastname} Age: {age}");
    }
}
class Program
{
    static void Main(string[]args)
    {
        Student student  = new Student();
        student.Print();
    }
}