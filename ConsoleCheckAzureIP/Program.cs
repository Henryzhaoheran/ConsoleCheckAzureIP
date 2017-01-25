using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ConsoleCheckAzureIP
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitString = "";
            // string checkIP = 
            
            while (exitString != "exit")
            {
                Console.WriteLine("\nPlease input the IP address: ");
                string CheckIP = Console.ReadLine();
                if (CheckIP == "exit")
                    exitString = CheckIP;
                else
                {
                    string url = "http://www.azurespeed.com/api/region?ipOrUrl=" + CheckIP;
                    WebRequest request = WebRequest.Create(url);
                    WebResponse response = request.GetResponse();
                    StreamReader sr = new StreamReader(response.GetResponseStream());
                    string html = sr.ReadToEnd();
                    Console.WriteLine(html);
                }
            }

            
            // Console.ReadKey();
        }
    }
}
