using Proxy.DAL.Interface;
using Proxy.Proxy;

namespace Proxy.DAL
{
    public static class DataSourceFactory
    {
        public static IEmployeeDataSource CreateEmployeeDataSource()
        {
            return EmployeeDataSourceProxy.GetInstance;
        }
    }
}
