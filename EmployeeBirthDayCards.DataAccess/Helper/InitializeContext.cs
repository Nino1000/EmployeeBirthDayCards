using EmployeeBirthDayCards.DataAccess.DBContextEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBirthDayCards.DataAccess.Helper
{
    public class InitializeContext
    {
        private EmployeeContext _employeeContext;

        public EmployeeContext EmployeeContext()
        {
            if (_employeeContext == null)
                _employeeContext = new EmployeeContext();

            return _employeeContext;

        }
    }
}
