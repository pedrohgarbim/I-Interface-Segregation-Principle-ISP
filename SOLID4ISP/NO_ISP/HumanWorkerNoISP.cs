using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID4ISP.NO_ISP
{
    public class HumanWorkerNoISP : IWorkerNoISP
    {
        public void Work()
        {
            Console.WriteLine("Humano trabalhando.");
        }

        public void Eat()
        {
            Console.WriteLine("Humano comendo.");
        }
    }
}
