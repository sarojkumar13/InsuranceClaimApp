using CsvHelper.Configuration;
using InsuranceClaimApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaimApp.CSVMapp
{
    public sealed class ClaimMap : ClassMap<Claim>
    {

        public ClaimMap()
        {
            Map(x => x.MemberId).Name("MemberID");
            Map(x => x.ClaimDate).Name("ClaimDate");
            Map(x => x.ClaimAmount).Name("ClaimAmount");
        }
    }
}

