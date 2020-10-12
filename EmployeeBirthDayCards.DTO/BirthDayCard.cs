using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBirthDayCards.DTO
{
    [DataContract]
    public class BirthDayCard
    {
        [DataMember]
        public string Message { get; set; }

    }
}
