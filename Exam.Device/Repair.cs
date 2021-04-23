using System;
namespace Exam.Devices
{
    public class Repair
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int DeviceId { get; set; }

        public Repair(int devID, decimal Price, string Desc)
        {
            this.DeviceId = devID;
            this.Price = Price;
            this.Description = Desc;
        }
    }
}
