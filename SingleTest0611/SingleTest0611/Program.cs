using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTest0611
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            for(int i = 0; i < 5; i++)
            {
                SingleTest st1 = new SingleTest(r);
                Console.WriteLine("인스턴스: " + st1.getData());

                Console.WriteLine("싱글톤: " + SingleTest.getInst(r).getData());
            }
            
            /*Console.Write(new SingleTest().getData());*/
        }
    }
}
