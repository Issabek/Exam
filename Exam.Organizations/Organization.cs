using System;

namespace Exam.Organizations
{
    public class Organization : IContactable
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
    public class Partner : IContactable
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
    public class Supplier : IContactable
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
    public class Customer : IContactable
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
