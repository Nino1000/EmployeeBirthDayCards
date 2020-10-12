using EmployeeBirthDayCards.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBirthDayCards.Interfaces.DataAccess
{
    public interface IDataAccessBirthDayCards
    {
        List<Employee> GetAllEmployeesBirthDaysToday(DateTime date);
        DateTime GetEmployeesBirthDayDate(int employeeId);
        BirthDayCard GenerateBirthDayCard();
    }
}
