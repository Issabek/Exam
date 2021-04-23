using System;
namespace Exam.Devices
{
    public class Software
    {
        public decimal Price { get; set; }
        public DateTime InstalationDate { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public Software(string Name, DateTime InstalationDate,decimal Price)
        {
            this.Price = Price;
            this.Name = Name;
            this.InstalationDate = InstalationDate;
        }
        public Software()
        {

        }
    }
}
