using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_Bank;

namespace test_bank_lib
{
    internal class Program
    {

        static void print(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            clsClient client = new clsClient();


                        
            print(client.first_name);
        }
    }
}
