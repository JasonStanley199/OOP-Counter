using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClockTest
{
    class ProgramClass
    {
        static public void Main(String[] args)
        {
            Clock cc = new Clock();
            while (true)
            {

                cc.Tick();
                Console.Clear();
                Console.WriteLine(cc.ReadTime());
                Thread.Sleep(1000);

            }
        }
    }
}
