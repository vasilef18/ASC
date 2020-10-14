using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegeaLuiMoor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Am rezolvat problema folosindu-ma de functia logaritm in baza 2.

            Console.WriteLine("Introduceti numarul de luni pentru a afla puterea de calcul bazata pe legea lui Moore");
            int n = int.Parse(Console.ReadLine());
            double ani = (Math.Log(n, 2) * 1.5);   //am folosit double pentru ca rezultatul este un numar real
            Console.WriteLine($"Veti avea o putere de calcul de {n} mai mare peste {ani} ani ");
        }
    }
}
