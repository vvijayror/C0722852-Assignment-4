using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0722852_Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Beowulf;
            static void Main(string[] args)
            {
                Program p = new Program();
                p.Beowulf = new ArrayList();

            }
            public void Run() { this.ReadTextFiles(); }

            public void ReadTextFiles()
            {
                using (StreamReader file = new StreamReader("U:/Users/722852/beowulf.txt"))
                {
                    int counter = 0;
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        Console.WriteLine(ln);
                        Beowulf.Add(ln);
                    }
                    file.Close();
                    Console.WriteLine($"File has {counter} lines.");
                }
            }

        }
    }
}
    }
}
