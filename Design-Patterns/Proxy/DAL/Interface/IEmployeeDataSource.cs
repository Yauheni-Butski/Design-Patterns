using Proxy.Model;

namespace Proxy.DAL.Interface
{
    public interface IEmployeeDataSource
    {
        Employee GetEmployee(int id);
        void SetEmployee(Employee employee);
    }
}