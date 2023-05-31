namespace CompanyWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CompanyService" in both code and config file together.
    public class CompanyService : ICompanyPublicService, ICompanyConfidentialService
    {
       
        public string GetConfidentialInformation()
        {
            return "This Is Confidential Information, TCP";
        }

        public string GetPublicInformation()
        {
            return "This Is Public Information, HTTP";
        }
    }
}
