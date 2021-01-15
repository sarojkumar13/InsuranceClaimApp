using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaimApp.Model
{
    public class Claim
    {
        public long Id { get; set; }
        public DateTime ClaimDate { get; set; }
        public decimal ClaimAmount { get; set; }
        public long MemberId { get; set; }
        public virtual Member Member { get; set; }
    }
}
