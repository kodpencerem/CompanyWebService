using System;

namespace CompanyWebServiceClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetPublicInfo_Click(object sender, EventArgs e)
        {
            CompanyServiceReference.CompanyPublicServiceClient client = new CompanyServiceReference.CompanyPublicServiceClient("NetHttpBinding_ICompanyPublicService");

            lblGetPublicInfo.Text = client.GetPublicInformation();

        }

        protected void btnGetConfidentialInfo_Click(object sender, EventArgs e)
        {
            CompanyServiceReference.CompanyConfidentialServiceClient client = new CompanyServiceReference.CompanyConfidentialServiceClient("NetTcpBinding_ICompanyConfidentialService");
            lblGetConfidentialInfo.Text = client.GetConfidentialInformation();
        }
    }
}