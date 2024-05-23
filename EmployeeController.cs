
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
public class EmployeeController : Controller
{
    public ActionResult Index()
    {


        // object initializer syntax
        Person p1 = new Person()
        {
            FirstName = "Samrat",
            Surname = "Belbase",
            Address = "Dhakabang",
            Gender = 'M',
            Salary = 200
        };
        Person p2 = new Person()
        {
            FirstName = "Sandesh",
            Surname = "Belbase",
            Address = "Dhakabang",
            Gender = 'M',
            Salary = 400
        };
        Person p3 = new Person()
        {
            FirstName = "Aarata",
            Surname = "Belbase",
            Address = "Dhakabang",
            Gender = 'F',
            Salary = 6000
        };
        Person p4 = new Person
        {
            FirstName = "Bishnu",
            Surname = "Belbase",
            Address = "Dhakabang",
            Gender = 'M',
            Salary = 40000
        };
        List<Person> employees = new List<Person>() { p1, p2, p3, p4 };
        return View(employees);
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'm';
    public double Salary { get; set; }
}
