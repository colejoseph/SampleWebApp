using SampleWebApp.CommonLibrary.Classes;

namespace SampleWebApp.BLL.Interfaces
{
    public interface IEmployeeMaintenance
    {
        Employee GetEmployee(string id);
        bool RemoveEmployee(string id);
        Employee UpdateEmployee(Employee employee);
    }
}
