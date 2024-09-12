using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID4ISP.WITH_ISP
{
    public class RobotWorker : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robô trabalhando.");
        }
    }
}
// agora a classe esta correta, nao precisa mais ser ter nela algo que nela nao é para ser 
// feito
