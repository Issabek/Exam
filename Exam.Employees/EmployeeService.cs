using System;
using System.Linq;
using System.Collections.Generic;
namespace Exam.Employees
{
    public class EmployeeService
    {
        public List<Employee> Employees { get; set; }
        public EmployeeService(List<Employee> employees)
        {
            this.Employees = employees;
        }
        public bool AddEmployee(Employee employee)
        {
            if (!Employees.Contains(employee))
            {
                Employees.Add(employee);
                return true;
            }
            return false;
        }
        public bool RemoveEmployee(Employee employee)
        {
            try
            {
                Employees.Remove(employee);
                return true;
            }
            catch
            {
                Console.WriteLine("Error happened on deleting employees: 31row employeeService.cs");
                return false;
            }
        }
        public bool EditEmployee(Employee employee)
        {
            try
            {
                Employees[Employees.FindIndex(p => p.Id == employee.Id)] = employee;
                return true;
            }
            catch
            {
                Console.WriteLine("Error happened on editing employees: 44row employeeService.cs");
                return false;
            }
        }
    }
}
