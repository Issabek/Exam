using System;
using Exam.Departments;
using Exam.Devices;
using Exam.Employees;
using Exam.Organizations;
using System.Collections.Generic;
namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            MainService service = new MainService();
            Organization org = new Organization() { Address = "Almaty", PhoneNumber = "+77774887638", Name = "Sulpak" };
            service.OrgServ.AddContact(org);
            org.Address = "Astana";
            service.OrgServ.EditContact(org);
            service.UpsertData(service.OrgServ.Contacts);

            Department dep = new Department(service.OrgServ.GetContactByName("Sulpak").Id, "OtdelProdaj");
            Employee emp = new Employee() { department = dep, FirstName = "Evgeniy", LastName = "Gertsen" };
            Software soft = new Software("Android 11", DateTime.Now, 9900);
            service.DepServ.AddDepartment(dep);
            service.EmpServ.AddEmployee(emp);
            service.DevServ.AddSoftware(soft);
            service.UpsertData(service.DepServ.Departments);
            service.UpsertData(service.DevServ.Softwares);
            service.UpsertData(service.EmpServ.Employees);

            Mobile mobile = new Mobile("Samsung", 500000, service.DevServ.Softwares[0].Id, service.EmpServ.Employees[0].Id, 12, 2, service.DepServ.Departments[0].Id, true, new DateTime(2019, 12, 1));
            service.DevServ.AddDevice(mobile);
            service.Finalize();
        }
    }




    //1. Если мы хотим чтобы класс был более практичным и "абстрактным" мы выбираем абстрактный класс.
    //2. Object
    //3. Начиная с C# 8.0 методы интерфейсов могут иметь модификаторы Private & Protected. А по дефолту все методы интерфейса публичные
    //4. Интерфейсы это единственный ссылочный тип который позволяет множественное наследование от себя
    //5. В случае множественного изменения строчного типа StringBuilder представляет собой более оптимизированную версию String, так как в отличие от String StringBuilder может быть изменен, а String при изменении создает уже новый объект
    //6. event это своего рода оповещалка, так как в крупных проектах не используется консоль,в следствии чего надо иметь другой способ оповещения событий. delegate же просто "указатель" на метод
    //7. Да, С# позволяет множественное наследование, но только от интерфейсов.
    //8. Поля с модификатором доступа protected доступен только наследуемым классам
    //9. Private модификатор доступа ограничивает наследование, на то он и приватный
    //10. protected internal это уровень доступа между public и protected. Он позволяет полю с таким модификатором быть наследованным либо быть использованным в локальной сборке.
}
