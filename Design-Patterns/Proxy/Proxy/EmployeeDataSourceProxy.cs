using System;
using System.Collections.Concurrent;

using Proxy.DAL;
using Proxy.DAL.Interface;
using Proxy.Model;

namespace Proxy.Proxy
{
    public class EmployeeDataSourceProxy : IEmployeeDataSource
    {
        //Singleton implementation
        private static readonly Lazy<EmployeeDataSourceProxy> Instance = 
            new Lazy<EmployeeDataSourceProxy>(() => new EmployeeDataSourceProxy());
        private readonly IEmployeeDataSource _dataSource = 
            new EmployeeDataSource();
        private readonly ConcurrentDictionary<int, Employee> _cache = 
            new ConcurrentDictionary<int, Employee>();

        public static EmployeeDataSourceProxy GetInstance => Instance.Value;

        public Employee GetEmployee(int id)
        {
            return _cache.GetOrAdd(id, _dataSource.GetEmployee);
        }

        public void SetEmployee(Employee employee)
        {
            _dataSource.SetEmployee(employee);

            _cache.AddOrUpdate(employee.Id,
                employee,
                (key, value) => employee);
        }
    }
}
