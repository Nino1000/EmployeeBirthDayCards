using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeBirthDayCards.Interfaces.Logic;
using EmployeeBirthDayCards.Interfaces.DataAccess;
using EmployeeBirthDayCards.DTO;

namespace EmployeeBirthDayCards.Logic
{
    public class EmployeeBirthDays : ILogicBirthDayCards
    {
        private readonly IDataAccessBirthDayCards _IDataAcessBirthDayCards;

        #region Constructors

        public EmployeeBirthDays(IDataAccessBirthDayCards IDataAcessBirthDayCards)
        {
            _IDataAcessBirthDayCards = IDataAcessBirthDayCards;
        }

        public EmployeeBirthDays()
        {

        }
        #endregion

        List<Employee> ILogicBirthDayCards.GetAllEmployeesBirthDaysToday(DateTime date)
        {
            List<Employee> employees;
            employees = _IDataAcessBirthDayCards.GetAllEmployeesBirthDaysToday(date);

            if (employees.Count() > 0)
            {
                foreach (var emp in employees)
                {
                    emp.birthDayCard = GenerateBirthDayCard();
                }
            }

            return employees;
        }

        DateTime ILogicBirthDayCards.GetEmployeesBirthDayDate(int employeeId)
        {
            return _IDataAcessBirthDayCards.GetEmployeesBirthDayDate(employeeId);
        }

        public BirthDayCard GenerateBirthDayCard()
        {
            return _IDataAcessBirthDayCards.GenerateBirthDayCard();
        }
    }
}
