using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;

namespace Lab_22_httpGetAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sync read of http data
            Uri bbc01 = new Uri("https://www.bbc.co.uk/");

            Console.WriteLine(bbc01.Host);
            Console.WriteLine(bbc01.Port);

            //Simplest way to read data is with 'webclient'
            var bbcWebClient = new WebClient { Proxy = null };
            bbcWebClient.DownloadFile("https://www.bbc.co.uk/", "yeet-the-bbcWebClient.html");
            Process.Start("yeet-the-bbcWebClient.html");
        }
    }
}
