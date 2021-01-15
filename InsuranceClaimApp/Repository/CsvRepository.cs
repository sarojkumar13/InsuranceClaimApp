using CsvHelper;
using InsuranceClaimApp.CSVMapp;
using InsuranceClaimApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClaimApp.Repository
{
    public class CsvRepository: ICsvRepository
    {
        public List<Claim> ReadCSVClaimFile(string location)
        {
            try
            {
                using (var reader = new StreamReader(location, Encoding.Default))
                using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CreateSpecificCulture("US")))
                {
                    csv.Configuration.RegisterClassMap<ClaimMap>();
                    var records = csv.GetRecords<Claim>().ToList();
                    return records;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Member> ReadCSVMemberFile(string location)
        {
            try
            {
                using (var reader = new StreamReader(location, Encoding.Default))
                using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CreateSpecificCulture("US")))
                {
                    csv.Configuration.RegisterClassMap<MemberMap>();
                    var records = csv.GetRecords<Member>().ToList();
                    return records;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
