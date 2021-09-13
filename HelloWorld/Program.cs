using System;
using Mylib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 0;
            var rs = MyMath.PTBacNhat(0, 10, out x);
            if (rs == MyMath.ketqua.VoSoNghiem)
                Console.WriteLine("PT co vo so nghiem");
            else if (rs == MyMath.ketqua.VoNghiem)
                Console.WriteLine("PT vo nghiem");
            else
                Console.WriteLine($"PT co 1 nghiem la {x} ");
            Console.ReadKey();
        }
    }
}
