using System;
using System.Collections.Concurrent;
using System.Threading;

using Proxy.DAL.Interface;
using Proxy.Model;

namespace Proxy.DAL
{
    public class EmployeeDataSource : IEmployeeDataSource
    {
        private readonly ConcurrentDictionary<int, Employee> _database 
            = new ConcurrentDictionary<int, Employee>();

        public Employee GetEmployee(int id)
        {
            Console.WriteLine("Loading {0} from DB...", id);
            //Emulate reading from database
            Thread.Sleep(1000);

            return _database.GetOrAdd(id, CreateNewEmployee);
        }

        public void SetEmployee(Employee employee)
        {
            Console.WriteLine("Saving ({0}, {1}) to DB...",
                employee.Id,
                employee.FullName);

            _database.AddOrUpdate(employee.Id,
                employee,
                (key, value) => employee);
        }

        private Employee CreateNewEmployee(int id)
        {
            return new Employee
            {
                Id = id,
                FullName = "[NoName]"
            };
        }
    }
}
