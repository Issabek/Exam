using System;
using Exam.Departments;
namespace Exam.Employees
{
    public interface IEmployee
    {
        int Id { get; set; }
        Department department { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    public class Employee:IEmployee
    {
        public Department department { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
