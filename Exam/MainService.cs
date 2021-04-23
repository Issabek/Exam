using System;
using Exam.DAL;
using Exam.Departments;
using Exam.Devices;
using Exam.Employees;
using Exam.Organizations;
using System.Collections.Generic;
namespace Exam
{
    public class MainService
    {
        static LiteDbEntity db = new LiteDbEntity(@"ExamTask.db");

        public DepartmentService DepServ = new DepartmentService(db.getCollection<Department>());
        public DeviceService DevServ = new DeviceService(db.getCollection<IDevice>(),db.getCollection<Software>(),db.getCollection<Repair>());
        public EmployeeService EmpServ = new EmployeeService(db.getCollection<Employee>());
        public OrganizationService OrgServ = new OrganizationService(db.getCollection<IContactable>());

        public bool UpsertData<T>(List<T> ts)
        {
            string s;
            db.UpsertRecords(ts, out s);
            if (ts[0].GetType() == typeof(IDevice) || ts[0].GetType() == typeof(Software) || ts[0].GetType() == typeof(Repair))
                DevServ = new DeviceService(db.getCollection<IDevice>(), db.getCollection<Software>(), db.getCollection<Repair>());
            else if (ts[0].GetType() == typeof(Department))
                DepServ.Departments = db.getCollection<Department>();
            else if (ts[0].GetType() == typeof(Employee))
                EmpServ.Employees = db.getCollection<Employee>();
            else if (ts[0].GetType() == typeof(Organization))
                OrgServ.Contacts = db.getCollection<IContactable>();
            return true;
        }
        public bool Finalize()
        {
            try
            {
                string ExMsg = "";
                db.UpsertRecords(DepServ.Departments, out ExMsg);
                db.UpsertRecords(DevServ.Devices, out ExMsg);
                db.UpsertRecords(EmpServ.Employees, out ExMsg);
                db.UpsertRecords(OrgServ.Contacts, out ExMsg);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public MainService()
        {

        }
    }
}
