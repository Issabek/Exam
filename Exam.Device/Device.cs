using System;

namespace Exam.Devices
{
    public interface IDevice
    {
         int Id { get; set; }
         DateTime ProdDate { get; set; }
         int WarrantyInMonths { get; set; }
         int ResponsibleEmployeeId { get; set; }
         int DepartmentId { get; set; }
         int SoftwareId { get; set; }
         decimal Price { get; set; }
         string Name { get; set; }
    }

    public class Printer : IDevice
    {
        public int Id { get; set; }
        public DateTime ProdDate { get ; set ; }
        public int WarrantyInMonths { get ; set ; }
        public int ResponsibleEmployeeId { get ; set ; }
        public int DepartmentId { get; set; }
        public int SoftwareId { get; set; }
        public decimal Price { get ; set ; }
        public bool isColored { get; set; }
        public string Name { get; set; }

        public Printer()
        {

        }
        public Printer(string Name,decimal Price, int SoftwareId,int ResponsibleEmployeeId,int WarrantyInMonths,int depID, DateTime ProdDate,bool isColored)
        {
            this.Name = Name;
            this.SoftwareId = SoftwareId;
            this.ResponsibleEmployeeId = ResponsibleEmployeeId;
            this.DepartmentId = depID;
            this.WarrantyInMonths = WarrantyInMonths;
            this.ProdDate = ProdDate;
            this.Price = Price;
            this.isColored = isColored;
        }
    }
    public class Computer : IDevice
    {
        public int Id { get; set; }
        public DateTime ProdDate { get; set; }
        public int WarrantyInMonths { get; set; }
        public int ResponsibleEmployeeId { get; set; }
        public int SoftwareId { get; set; }
        public decimal Price { get; set; }
        public int DepartmentId { get; set; }
        public int Storage { get; set; }
        public string Name { get; set; }
        public Computer()
        {

        }
        public Computer(string Name, decimal Price, int SoftwareId, int ResponsibleEmployeeId, int WarrantyInMonths,int Storage,int depID, DateTime ProdDate)
        {
            this.Name = Name;
            this.SoftwareId = SoftwareId;
            this.ResponsibleEmployeeId = ResponsibleEmployeeId;
            this.WarrantyInMonths = WarrantyInMonths;
            this.DepartmentId = depID;
            this.ProdDate = ProdDate;
            this.Price = Price;
            this.Storage = Storage;
        }
    }
    public class Mobile : IDevice
    {
        public int Id { get; set; }
        public DateTime ProdDate { get; set; }
        public int WarrantyInMonths { get; set; }
        public int ResponsibleEmployeeId { get; set; }
        public int SoftwareId { get; set; }
        public decimal Price { get; set; }
        public int DepartmentId { get; set; }
        public bool IsSensored { get; set; }
        public int SimQty { get; set; }
        public string Name { get; set; }
        public Mobile()
        {

        }
        public Mobile(string Name, decimal Price, int SoftwareId, int ResponsibleEmployeeId, int WarrantyInMonths,int SimQty,int depID,bool isSensored, DateTime ProdDate)
        {
            this.Name = Name;
            this.SoftwareId = SoftwareId;
            this.DepartmentId = depID;
            this.ResponsibleEmployeeId = ResponsibleEmployeeId;
            this.WarrantyInMonths = WarrantyInMonths;
            this.ProdDate = ProdDate;
            this.Price = Price;
            this.IsSensored = isSensored;
            this.SimQty = SimQty;
        }
    }
}
