using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaimApp.Model
{
    // No Vildations are added
    public class Member
    {
        public long Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public ICollection<Claim> Claims { get; set; }
    }
}
