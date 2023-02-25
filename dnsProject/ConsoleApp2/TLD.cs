using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApp2
{
    class TLD
    {
        string tld;
        ArrayList websites = new ArrayList();
        string path = @"D:\dnsProject\websites\com.txt";


        public TLD(string tld) // const
        {
            this.tld = tld; // the tld input includes the "." 
            refresh();
        }
        public void refresh()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string domain;
                string ip;
                websites.Clear();
                while ((domain = reader.ReadLine()) != null)
                {
                    if (domain == this.tld)
                    {
                        while ((domain = reader.ReadLine()).Substring(0, 1) != (".")) // text file MUST be ending with "."
                        {
                            ip = reader.ReadLine();
                            websites.Add(new website(domain, this.tld, ip));
                        }
                    }
                }
            }
        }
        public website search(string domain)
        {
            foreach (website web in websites)
            {
                if (web.getDomain() == domain)
                    return web;
            }
            return null;
        }
        public void print()
        {
            Console.WriteLine("                                             websites: \r\n");
            Console.WriteLine("                                             domain:          ip:             ");
            foreach (website web in websites)
            {
                Console.WriteLine("                                           "+web.getDomain()+ "   " + web.getIp());
            }
        }
        public int Count()
        {
            return websites.Count;
        }
        public string getTLD()
        {
            return tld;
        }

    }
}
