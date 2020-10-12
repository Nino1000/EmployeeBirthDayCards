using EmployeeBirthDayCards.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBirthDayCards.Interfaces.Logic
{
    public interface ILogicBirthDayCards
    {
        List<Employee> GetAllEmployeesBirthDaysToday(DateTime date);

        DateTime GetEmployeesBirthDayDate(int employeeId);

        BirthDayCard GenerateBirthDayCard();
    }
}
