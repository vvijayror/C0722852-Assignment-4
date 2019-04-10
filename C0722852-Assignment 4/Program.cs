using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace C0722852_Assignment_4
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            
      
                Program p = new Program();
                p.Beowulf = new ArrayList();
                p.ReadTextFiles();

            }
            public void Run() { this.ReadTextFiles(); }

            public void ReadTextFiles()
            {
                using (StreamReader file = new StreamReader("U:/Users/722852/beowulf.txt"))
                {

                int counter = 0;
                int number = 0;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains("Fare") == true && line.Contains("War") == false || line.Contains("Fare") == true && line.Contains("War") == false)
                    {
                        int x = counter - 1;
                        number++;
                    }
               
                    counter++;
                }
                Console.WriteLine($"The number of lines that contains *Fare* without the word *War* are {number}");
                file.Close();


                Console.WriteLine($"File has {counter} lines.");
                }
            }

        }
    }

   
