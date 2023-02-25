using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Root root = new Root();

            TLD edu = new TLD(".edu");
            TLD com = new TLD(".com");
            TLD org = new TLD(".org");
            root.addTLD(edu);
            root.addTLD(com);
            root.addTLD(org);

            root.Run();


        }
    }
}
