using System;
using System.Linq;
using System.Collections.Generic;
namespace Exam.Departments
{
    public class DepartmentService
    {
        public List<Department> Departments { get; set; }
        public DepartmentService(List<Department> departments)
        {
            this.Departments = departments;
        }
        public bool AddDepartment(Department department)
        {
            if (!Departments.Contains(department))
            {
                Departments.Add(department);
                return true;
            }
            return false;
        }
        public bool RemoveDepartment(Department department)
        {
            try
            {
                Departments.Remove(department);
                return true;
            }
            catch
            {
                Console.WriteLine("Error happened on deleting Repairs: 31row departmentService.cs");
                return false;
            }
        }
        public bool EditDepartment(Department department)
        {
            try
            {
                Departments[Departments.FindIndex(p => p.Id == department.Id)] = department;
                return true;
            }
            catch
            {
                Console.WriteLine("Error happened on editing departments: 44row departmentService.cs");
                return false;
            }
        }
    }
}
