using System;

namespace Exam.Departments
{
    public class Department
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public Department(int orgID, string Name)
        {
            this.OrganizationId = orgID;
            this.Name = Name;
        }
        public Department()
        {

        }
    }

}
