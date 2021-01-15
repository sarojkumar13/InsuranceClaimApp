using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaimApp.Model
{
    public class MemberMap:ClassMap<Member>
    {
        public MemberMap()
        {
            Map(x => x.Id).Name("MemberID");
            Map(x => x.EnrollmentDate).Name("EnrollmentDate");
            Map(x => x.FirstName).Name("FirstName");
            Map(x => x.Lastname).Name("LastName");
        }
    }
}
