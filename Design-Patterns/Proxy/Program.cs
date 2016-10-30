using System;

using Proxy.DAL;
using Proxy.DAL.Interface;
using Proxy.Model;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEmployeeDataSource dataSource = DataSourceFactory.CreateEmployeeDataSource();

            ShowEmployeeInfo(11, dataSource);
            ShowEmployeeInfo(12, dataSource);

            SetEmployeeName(11, "Sergei Pytin", dataSource);
            SetEmployeeName(12, "Alexei Medvedev", dataSource);

            ShowEmployeeInfo(11, dataSource);
            ShowEmployeeInfo(12, dataSource);

            Console.WriteLine("Done ...");
            Console.ReadKey(true);
        }

        private static void ShowEmployeeInfo(int id, IEmployeeDataSource dataSource)
        {
            Employee employeeInfo = dataSource.GetEmployee(id);
            Console.WriteLine("Employee id = {0}", employeeInfo.Id);
            Console.WriteLine("Employee name = {0}", employeeInfo.FullName);
        }

        private static void SetEmployeeName(int id, string fullName, IEmployeeDataSource dataSource)
        {
            Employee employeeInfo = dataSource.GetEmployee(id);
            employeeInfo.FullName = fullName;
            dataSource.SetEmployee(employeeInfo);
        }
    }
}
