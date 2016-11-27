using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton09
{
    class Program
    {
        static void Main(string[] args)
        {
            // 32Bitでビルドされると実行時にオーバーフローが発生する。
            IntPtr a = (IntPtr)0x123456789;
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
