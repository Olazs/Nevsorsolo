using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nevsorsolo

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] knev;
            knev = File.ReadAllLines("knev.txt");

            /*
            foreach (string item in knev)
            {
                Console.Write(item+";");
            }*/
            int knevIndex; 
            Random rnd = new Random();
            for (int i = 1; i <= 1; i++)
            {
                knevIndex = rnd.Next(knev.Length);
                
                Console.WriteLine( " " + knev[knevIndex]);
            }
        }
    }
}
