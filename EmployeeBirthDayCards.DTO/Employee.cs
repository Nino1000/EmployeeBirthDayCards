using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBirthDayCards.DTO
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Employee_Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public DateTime Birth_Date { get; set; }

        [DataMember]
        public string Email_Address { get; set; }

        [DataMember]
        public BirthDayCard birthDayCard { get; set; }

    }
}
