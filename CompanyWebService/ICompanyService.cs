using System.ServiceModel;

namespace CompanyWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICompanyService" in both code and config file together.
    [ServiceContract]
    public interface ICompanyService
    {
        [OperationContract]
        void DoWork();
    }
}
