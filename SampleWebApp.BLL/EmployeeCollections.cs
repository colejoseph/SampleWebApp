using SampleWebApp.BLL.Interfaces;
using SampleWebApp.CommonLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleWebApp.BLL
{
    public class EmployeeCollections : IEmployeeCollections
    {
        public void Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetListByFK(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Employee> Query()
        {
            throw new NotImplementedException();
        }

        public Employee Save(Employee entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> Search(Expression<Func<Employee, bool>> query)
        {
            throw new NotImplementedException();
        }
    }
}
