using EmployeeBirthDayCards.DTO;
using EmployeeBirthDayCards.Interfaces.Logic;
using EmployeeBirthDayCards.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace EmployeeBirthDayCards
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeBirthDayCardService : IServiceBirthDayCards
    {
        private readonly ILogicBirthDayCards _IlogicBirthDayCards;

        #region Constructors

        public EmployeeBirthDayCardService(ILogicBirthDayCards IlogicBirthDayCards)
        {
            _IlogicBirthDayCards = IlogicBirthDayCards;
        }

        public EmployeeBirthDayCardService()
        {

        }


        #endregion
        List<Employee> IServiceBirthDayCards.GetAllEmployeesBirthDaysToday(DateTime date)
        {
            try
            {
                return _IlogicBirthDayCards.GetAllEmployeesBirthDaysToday(Convert.ToDateTime(date));
            }
            catch (Exception ex)
            {
                throw new FaultException<ExceptionDetail>(new ExceptionDetail(ex), ex.Message);
            }
        }

        public DateTime GetEmployeesBirthDayDate(int employeeId)
        {
            try
            {
                return _IlogicBirthDayCards.GetEmployeesBirthDayDate(employeeId);
            }
            catch (Exception ex)
            {
                throw new FaultException<ExceptionDetail>(new ExceptionDetail(ex), ex.Message);
            }
        }
    }
}
