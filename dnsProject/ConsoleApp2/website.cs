using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
namespace ConsoleApp2
{
    public class website
    {
        string domain;
        string tld; 
        string ip;
        public website(string domain, string tld, string ip)
        {
            this.domain = domain;
            this.tld = tld;
            this.ip = ip;
        }
        public string getDomain()
        {
            return domain;
        }
        public string getTld()
        {
            return tld;
        }
        public string getIp()
        {
            return ip;
        }
        public void print()
        {
            Console.WriteLine("                    Domain: " + domain);
            Console.WriteLine("                    ip: " + ip);
        }
    }
}
