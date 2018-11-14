using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService
{
    [ServiceContract]
    public interface ICompanyPublicService
    {
        //Bu methoda herkes erişebilir olacak, yani HTTP üzerinden Firewall'a takılmadan erişim
        [OperationContract]
        string GetPublicInformation();
    }


    [ServiceContract]
    public interface ICompanyConfidentialService
    {
        //Bu methoda sadece, firewall üzerinden, employeeler erişebilir olacak, o nedenle bu TCP protokolü ile erişilebilicek
        [OperationContract]
        string GetConfidentialInformation();
    }
}
