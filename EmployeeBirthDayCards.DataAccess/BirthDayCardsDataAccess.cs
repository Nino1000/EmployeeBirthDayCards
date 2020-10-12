using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeBirthDayCards.DataAccess.DBContextEntities;
using EmployeeBirthDayCards.DataAccess.Helper;
using EmployeeBirthDayCards.DTO;
using EmployeeBirthDayCards.Interfaces.DataAccess;
using EmployeeBirthDayCards.DataAccess.AutoMapper;
using AutoMapper;

namespace EmployeeBirthDayCards.DataAccess
{
    public class BirthDayCardsDataAccess : IDataAccessBirthDayCards
    {
        private readonly EmployeeContext _employeeContext;

        public BirthDayCardsDataAccess()
        {
            _employeeContext = new InitializeContext().EmployeeContext();
            AutoMapperSetup.Initialise();
        }

        public BirthDayCardsDataAccess(EmployeeContext context)
        {
            _employeeContext = context;
            AutoMapperSetup.Initialise();
        }


        public BirthDayCard GenerateBirthDayCard()
        {
            BirthDayCard birthDayCards = new BirthDayCard()
            {
                Message = "Happy birthday Hope you have a wonderful day"
            };

            return birthDayCards;
        }

        List<DTO.Employee> IDataAccessBirthDayCards.GetAllEmployeesBirthDaysToday(DateTime date)
        {
                List<DBContextEntities.Employee> employeeList;
                employeeList = _employeeContext.Employees.Where(x => x.Birth_Date == date).ToList();

                return Mapper.Instance.Map<List<DTO.Employee>>(employeeList);
        }

        DateTime IDataAccessBirthDayCards.GetEmployeesBirthDayDate(int employeeId)
        {
            return _employeeContext.Employees.Where(x => x.Employee_Id == employeeId).Select(x=> x.Birth_Date).FirstOrDefault();
        }
    }
}
