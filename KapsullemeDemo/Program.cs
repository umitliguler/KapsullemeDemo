using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dikdortgen = new Dikdortgen();
            dikdortgen.A = -50;
            dikdortgen.B = 125;

            Console.WriteLine(dikdortgen.Alan);

            Console.ReadKey();

        }
    }
}
