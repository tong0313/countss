using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] blood = { "A","AB","O","B","A", "A", "AB", "O", "B", "A" };

            int count = 0;
            int bloodA = 0;
            int bloodB = 0;
            int bloodO = 0;
            int bloodAB = 0;



            for (int i = 0; i < blood.Length; i++)
            {
                count++;
                Console.WriteLine(blood[i]);
                if (blood[i] == "A")
                {
                    bloodA++;
                    
                }
               else if (blood[i] == "B")
                {
                    bloodB++;

                }
              else  if (blood[i] == "O")
                {
                    bloodO++;

                }
                else
                {
                    bloodAB++; 

                }

            }
            double percentA;
            double percentB;
            double percentO;
            double percentAB;

            percentA = (double)bloodA / (double)blood.Length;
            percentB = (double)bloodB / (double)blood.Length;
            percentO = (double)bloodO / (double)blood.Length;
            percentAB = (double)bloodAB / (double)blood.Length;



            Console.WriteLine("A型的人 : " + bloodA +"  "+ "B型的人 : " + bloodB + "  " + "O型的人 : " + bloodO + "  "+ "AB型的人 : " + bloodAB);
            Console.WriteLine("A型的%數 : " + percentA * 100 + "%" );
            Console.WriteLine("B型的%數 : " + percentB * 100 + "%");
            Console.WriteLine("O型的%數 : " + percentO * 100 + "%");
            Console.WriteLine("AB型的%數 : " + percentAB * 100 + "%");

            Console.ReadLine();

        }
    }
}
