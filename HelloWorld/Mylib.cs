using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylib
{
    public class MyMath
    {
        /// <summary>
        /// Giải phương trình bậc nhất 
        /// </summary>
        /// <param name="a">Tham số a </param>
        /// <param name="b">Tham số b </param>
        /// <param name="x">Nghiệm của pt nếu có </param>
        /// <returns>
        /// -1: pt vô nghiệm 
        ///  0: phương trình có vô sô nghiệm 
        /// -1: phương trình có 1 nghiệm 
        /// </returns>
        public static ketqua PTBacNhat(int a, int b, out float x)
        {
            x = 0;
            if (a == 0)
            {
                if (b == 0)
                    return ketqua.VoSoNghiem;
                else
                    return ketqua.VoNghiem;
            }
            else
            {
                x = (float)-b / a;
                return ketqua.MotNghiem;
            }
        }
        public enum ketqua
        {
            VoNghiem,
            VoSoNghiem,
            MotNghiem,
            HaiNghiem
        }

       /* public static long TongNSo(int n)
        {
            long rs = 0;
            for (int i = 0; i <= n; i++)
            {
                rs += (long)i;
            }
        }

        public static long TongNSoDeQuy(int n)
        {
            if(n == 0)
                return 0;
            else 
                return n + TongNSoDeQuy(n-1);
        }*/

    }

    public class Point
    {
        public int x
        { 
            get; set;
        }
        public int y
        {
            get; set;
        }
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }
        /// <summary>
        /// Tính khoảng cách từ điểm hiện tại đến gốc tọa độ O(0,0)
        /// </summary>
        /// <returns>Khoảng cách đến O</returns>
        public double Distance()
        {
            double d = Math.Sqrt(x * x + y * y);
            return d;
        }
        /// <summary>
        /// Tính khoảng cách đên điểm p
        /// Hàm oveloading của hàm Distance
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public double Distance(Point p)
        {
            double d = Math.Sqrt(Math.Pow(x -p.x, 2) + Math.Pow( y-p.y, 2));
            return d;
        }


        /// <summary>
        /// Tính khoảng cách từ điểm a --> b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Distance(Point a, Point b)
        {
            double d = Math.Sqrt(Math.Pow(a.x -b.x, 2)  + Math.Pow(a.y -b.y, 2));
            return d;
        }

        public override string ToString()
        {
            return $"Toa do cua diem la ({x} {y})";
        }
    }
}
