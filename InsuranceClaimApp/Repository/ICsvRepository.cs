using InsuranceClaimApp.Model;
using System.Collections.Generic;

namespace InsuranceClaimApp.Repository
{
    public interface ICsvRepository
    {
        List<Claim> ReadCSVClaimFile(string location);
        List<Member> ReadCSVMemberFile(string location);
    }
}