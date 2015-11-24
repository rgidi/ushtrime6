using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static void GjeneroRastet(int A, int B, int[] y)
        {
            FileStream fs = new FileStream(@"C:\\Users\\GRKN\\Documents\\Visual Studio 2013\\Projects\\ConsoleApplication2\\ConsoleApplication2\\Inputet", FileMode.OpenOrCreate, FileAccess.Write);
            Console.WriteLine("File created");
            fs.Close();
            StreamWriter sw = new StreamWriter(@"C:\\Users\\GRKN\\Documents\\Visual Studio 2013\\Projects\\ConsoleApplication2\\ConsoleApplication2\\Inputet");

            int x; int i;
            for (x = A; x <= B; x++)
            {
                for (i = 0; i <= 4; i++)
                {
                    sw.Write("{0} {1}\n", x, y[i]);
                }
            }

            sw.Close();
        }

        public Double FunksioniOrigjinal(Double x, Double y)
        {
            Double z = x + (2 / y);
            return z;
        }

        public void Llogarit(string file1, string file2)
        {
            FileStream fs = new FileStream(file2, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            StreamWriter sw = new StreamWriter(file2);


            foreach (var line in File.ReadLines(file1))
            {
                Double z;
                var values = line.Split(' ');
                Double a = Convert.ToDouble(values[0]);
                Double b = Convert.ToDouble(values[1]);
                z = FunksioniOrigjinal(a,b);
                
                sw.Write("{0}\n", z);
            }
        }

       

        static void Main(string[] args)
        {
            int A = -99, B = 999; int i;
            int[] y = new int[5];
            Console.Write("Lexo M, N, P, Q, R :\n");

            for (i = 0; i < 5; i++)
            {
                y[i] = Convert.ToInt32(Console.ReadLine());
            }
            Program p = new Program();
            GjeneroRastet(A, B, y);
            p.Llogarit(@"C:\\Users\\GRKN\\Documents\\Visual Studio 2013\\Projects\\ConsoleApplication2\\ConsoleApplication2\\Inputet", @"C:\\Users\\GRKN\\Documents\\Visual Studio 2013\\Projects\\ConsoleApplication2\\ConsoleApplication2\\Outputet");

        }
    }
}
