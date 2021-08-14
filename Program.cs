using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tr = new List<string>();
            using (StreamReader sr = new StreamReader(@".\textfile.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    tr.Add(line);
                }
            }
            string b = "fish";
            var mv = tr.Where(x => x.Contains(b)).ToList();
            if (mv != null)
            {
                Console.WriteLine("Matches found: " + mv.Count());
                foreach (string m in mv)
                {
                    Console.WriteLine(m);
                    Console.WriteLine(tr.IndexOf(m));
                }

            }

            //Console.WriteLine(tr.IndexOf("I like to buy swan"));

            //if(tr.Contains(b)== true)
            //{
            //    Console.WriteLine("found");
            //    Console.WriteLine(tr.IndexOf(b));
            //}




            Console.ReadLine();
        }

       
    }
}
