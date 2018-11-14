using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CompanyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CompanyService.svc or CompanyService.svc.cs at the Solution Explorer and start debugging.
    public class CompanyService : ICompanyPublicService, ICompanyConfidentialService
    {
        public string GetConfidentialInformation()
        {
            return "This is confidential info and only available over TCP behind the company firewall";
        }

        public string GetPublicInformation()
        {
            return "This is public information and available over HTTP to all general public outside the firewall";
        }
    }
}
