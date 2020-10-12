using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeBirthDayCards.DataAccess;

namespace EmployeeBirthDayCards.DataAccess.AutoMapper
{
    public class AutoMapperSetup
    {
        private static bool initialized = false;

        public static void Initialise()
        {
            // Check if automapper is initialized else init it.
            if (!initialized)
            {    //this should load all the profiles that are in the same dll as the typed profile.
                Mapper.Initialize(cfg =>
                {
                    cfg.SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
                    cfg.DestinationMemberNamingConvention = new PascalCaseNamingConvention();
                    cfg.ReplaceMemberName("_", "");
                    cfg.ValidateInlineMaps = false;
                    cfg.CreateMap<DTO.Employee, DBContextEntities.Employee>(MemberList.None);
                });
                initialized = true;
            }
        }
    }
}
