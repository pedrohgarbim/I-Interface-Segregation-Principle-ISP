using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID4ISP.NO_ISP
{
    public class RobotWorkerNoISP : IWorkerNoISP
    {
        public void Work()
        {
            Console.WriteLine("Robô trabalhando.");
        }

        public void Eat()
        {
            // Robôs não comem, mas ainda são obrigados a implementar este método.
            // throw new NotSupportedException("Robôs não comem.");
            Console.WriteLine("Robôs não comem.");
        }
    }
}
