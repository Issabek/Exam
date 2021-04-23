using System;
namespace Exam.Organizations
{
    public interface IContactable
    {
         string PhoneNumber { get; set; }
         string Address { get; set; }
         string Name { get; set; }
         int Id { get; set; }
    }

}
