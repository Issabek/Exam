using System;
using System.Collections.Generic;
using System.Linq;
namespace Exam.Devices
{
    public class DeviceService
    {
        public List<IDevice> Devices { get; set; }
        public List<Software> Softwares { get; set; }
        public List<Repair> Repairs { get; set; }
        public DeviceService(List<IDevice> devices, List<Software> Softwares, List<Repair> repairs)
        {
            this.Devices = devices;
            this.Softwares = Softwares;
            this.Repairs = repairs;
        }
        public DeviceService()
        {

        }
        public bool AddDevice(IDevice device)
        {
            if (!Devices.Contains(device))
            {
                Devices.Add(device);
                return true;
            }
            return false;
        }
        public bool RemoveDevice(IDevice device)
        {
            try
            {
                Devices.Remove(device);
                return true;
            }
            catch
            {
                Console.WriteLine("Error happened on deleting device: 35row DeviceService.cs");
                return false;
            }
        }
        public bool EditDevice(IDevice device)
        {
            try
            {
                Devices[Devices.FindIndex(p => p.Id == device.Id)] = device;
                return true;
            }
            catch
            {
                Console.WriteLine("Error happened on deleting device: 48row DeviceService.cs");
                return false;
            }
        }
        public IDevice GetDeviceByName(string name)
        {
            try
            {
                return Devices.Where(d => d.Name == name).First();
            }
            catch
            {
                Console.WriteLine("Error happened on deleting device: 48row DeviceService.cs");
                return null;
            }
        }
        public bool AddSoftware(Software soft)
        {
            if (!Softwares.Contains(soft))
            {
                Softwares.Add(soft);
                return true;
            }
            return false;
        }
        public bool RemoveSoftware(Software soft)
        {
            try
            {
                Softwares.Remove(soft);
                return true;
            }
            catch
            {
                Console.WriteLine("Error happened on deleting device: 84row DeviceService.cs");
                return false;
            }
        }
        public bool EditSoftware(Software soft)
        {
            try
            {
                Softwares[Softwares.FindIndex(p => p.Id == soft.Id)] = soft;
                return true;
            }
            catch
            {
                Console.WriteLine("Error happened on editing device: 97row DeviceService.cs");
                return false;
            }
        }

        public bool AddRepair(Repair repair)
        {
            if (!Repairs.Contains(repair))
            {
                Repairs.Add(repair);
                return true;
            }
            return false;
        }
        public bool RemoveRepair(Repair repair)
        {
            try
            {
                Repairs.Remove(repair);
                return true;
            }
            catch
            {
                Console.WriteLine("Error happened on deleting Repairs: 122row DeviceService.cs");
                return false;
            }
        }
        public bool EditRepair(Repair repair)
        {
            try
            {
                Repairs[Repairs.FindIndex(p => p.Id == repair.Id)] = repair;
                return true;
            }
            catch
            {
                Console.WriteLine("Error happened on editing Repairs: 135row DeviceService.cs");
                return false;
            }
        }


        public List<Repair> GetAllRepairs(int DeviceID)
        {
           return Repairs.Where(r => r.DeviceId == DeviceID).ToList();
        }

    }
}
