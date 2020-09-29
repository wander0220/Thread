using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadA
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread ta = new Thread(TestMethod);
        }

        public void TestMethod()
        {

        }
    }
}
