using CsvHelper;
using InsuranceClaimApp.CSVMapp;
using InsuranceClaimApp.Model;
using InsuranceClaimApp.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClaimApp.Service
{
    public class ClaimService : IClaimService
    {

        private readonly ICsvRepository _repository;
        private readonly IConfiguration _config;
        private readonly IWebHostEnvironment _env;

        public ClaimService(IWebHostEnvironment env, ICsvRepository repository)
        {
            _env = env;
            _repository = repository;
        }
        public List<Member> GetClaim(string date)
        {

            var path1 = @"D:\Learning\InsuranceClaimApp\Files\Claim.CSV";
            var path2 = @"D:\Learning\InsuranceClaimApp\Files\Member.CSV";

            var claims = _repository.ReadCSVClaimFile(path1).Where(dt => dt.ClaimDate <= DateTime.Parse(date));

            if (claims == null)
            {
                return new List<Member>();
            }

            var members = _repository.ReadCSVMemberFile(path2);

            foreach (var mem in members)
            {
                var memberclaims = claims.Where(memberid => memberid.MemberId == mem.Id).ToList();
                mem.Claims = memberclaims;
            }

            return members.Where(cl => cl.Claims.Count() > 0).ToList();

        }

    }
}
