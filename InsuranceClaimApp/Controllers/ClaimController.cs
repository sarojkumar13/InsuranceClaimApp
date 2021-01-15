using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsuranceClaimApp.Model;
using InsuranceClaimApp.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InsuranceClaimApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClaimController : ControllerBase
    {
        private readonly IClaimService _claimService;

        public ClaimController(IClaimService claimService)
        {
            _claimService = claimService;
        }     
        
        [HttpPost("GetClaim")]
        public IEnumerable<Member>GetClaim([FromBody] string date)
        {
            return _claimService.GetClaim(date);
        }
    }
}
