using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.DIP
{
    class EmployeeBusinessLogic2
    {
        IEmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLogic2()
        {
            _EmployeeDataAccess = DataAccessFactory2.GetEmployeeDataAccessObj();
        }

        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
