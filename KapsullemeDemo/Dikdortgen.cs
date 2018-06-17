using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeDemo
{
    public class Dikdortgen
    {
        private int a;

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
            }
        }

        public int B { get; set; }

        public int Alan
        {
            get
            {
                if (A < 0 || B <0)
                {
                    return 0;
                }
                return A * B;
            }
        }

    }
}
