using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp2
{
    class Root
    {
        public static ArrayList TLDs = new ArrayList();
        public Root()
        {

        }
        public void addTLD(TLD tld )
        {
            foreach (TLD index in TLDs)
            {
                if (index.getTLD() == tld.getTLD())
                    TLDs.Remove(index);
            }
            TLDs.Add(tld); 
        }
        public website search(string domain) // gets domain and starts filtering it
        {
            TLD currentTLD = null;
            try
            {
                foreach (TLD index in TLDs)
                {
                    if (domain.IndexOf(index.getTLD()) != -1)
                        currentTLD = index;
                }
                if (currentTLD == null)
                    throw new NullReferenceException();
                return (currentTLD.search(domain)); // try&catch to avoid null refrence ex'
            }
            catch
            {
                Console.WriteLine("nomain doesnt exist!");
                return null;
                
            }



        }
        public void printTLDs() //prints all the TLDs the root server is holding
        {
            Console.WriteLine("                                                       TLDs:    \r\n");
            foreach (TLD tld in TLDs)
                Console.WriteLine("                                                       " + tld.getTLD());
        }
        public ArrayList getTLDs() //returns all the TLDs the root server is holding
        {
            return TLDs;
        }

        public void refresh()
        {
            foreach (TLD index in TLDs)
            {
                index.refresh();
            }
            Console.WriteLine("Done!");
        }

        //the real power
        public void Run() //closed loop runs as long as the Console is running
        {
            while (1 == 1)
            {
                Console.WriteLine("//help:\r\n 1. TLDs - to print all the tlds \r\n 2. WEBSITE - to show the websites in TLD youll choose later \r\n 3. search \r\n 4. refresh  \r\n clear   ");
                string input = Console.ReadLine();
                ArrayList tlds = getTLDs();
                if (input == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    printTLDs();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (input == "2")
                {
                    Console.WriteLine("name TLD to browse");
                    string tld = Console.ReadLine();

                    foreach (TLD index in tlds)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (index.getTLD() == tld)
                            index.print();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else if (input == "3") // search
                {
                    website demanded = null;
                    Console.WriteLine("enter domain: ");
                    string domain = Console.ReadLine();
                    demanded = search(domain);
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (demanded == null)
                        Console.WriteLine("no such website!");
                    else
                        demanded.print();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (input == "4")
                    refresh();
                else if (input == "clear")
                    Console.Clear();



                else
                    Console.WriteLine("error");

            }
        }
    }
}
