using System;
using System.ServiceModel;

namespace CompanyWebServiceHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CompanyWebService.CompanyService)))
            {
                host.Open();
                Console.WriteLine("Host started @" + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
