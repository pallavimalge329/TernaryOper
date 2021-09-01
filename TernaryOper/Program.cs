using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOper
{
    class Program
    {
        static void Main(string[] args)
        {
           
                string cname = "Pallavi";
                int withdrwal = 7000;
                int balance = 10000;

                Console.WriteLine("Customer Name: {0}", cname);
                Console.WriteLine("Withdrwal Amount: {0}", withdrwal);
                Console.WriteLine("\n");



                var transaction = withdrwal > balance ? balance : balance - withdrwal;

                Console.WriteLine("Transaction Result = " + transaction);
                Console.ReadKey();




            }
        }
    }

