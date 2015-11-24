using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;
using System.Data;
using System.IO;
using System.Diagnostics;

namespace ConsoleApplication1
{
    [TestFixture]
    class UnitTest
    {
        [TestCase]
        public void Testo()
        {
            Program p = new Program();
            string file1 = @"C:\\Users\\GRKN\\Documents\\Visual Studio 2013\\Projects\\ConsoleApplication2\\ConsoleApplication2\\Inputet";
            string file2 = @"C:\\Users\\GRKN\\Documents\\Visual Studio 2013\\Projects\\ConsoleApplication2\\ConsoleApplication2\\Outputet";
            FileStream fs1 = new FileStream(file1, FileMode.OpenOrCreate, FileAccess.Read);
            FileStream fs2 = new FileStream(file2, FileMode.OpenOrCreate, FileAccess.Write);
            fs1.Close(); fs2.Close();
            foreach (var l in File.ReadLines(file1))
            {
                foreach (var m in File.ReadLines(file2))
                {
                    var v1 = l.Split(' ');
                    var v2 = m;
                    // marr si vlera te pritura rezultatet e perftuara nga metoda: Funksioni
                    Assert.AreEqual(v2[0], p.FunksioniOrigjinal(Convert.ToDouble(v1[0]), Convert.ToDouble(v1[1])));
                    Debug.Assert(v2[0] != 0, "nuk lejohet vlera zero!.");
                }
            }
        }
    }
}