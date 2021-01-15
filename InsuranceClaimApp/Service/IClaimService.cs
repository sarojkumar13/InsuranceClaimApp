using InsuranceClaimApp.Model;
using System;
using System.Collections.Generic;

namespace InsuranceClaimApp.Service
{
    public interface IClaimService
    {
        List<Member> GetClaim(string date);
    }
}