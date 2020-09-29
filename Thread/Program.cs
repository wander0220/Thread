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
            Thread threadA = new Thread(TestMethod);
            Thread threadB = new Thread(delegate () {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine("B");
                }
            });
            Thread threadC = new Thread(() => {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine("C");
                }
            });

            threadA.Start();
            threadB.Start();
            threadC.Start();
        }

        private static void TestMethod()
        {
            //Console.WriteLine("아아아아");

            for(int i=0;i<1000; i++)
            {
                Console.WriteLine("A");
            }
        }
    }
}
