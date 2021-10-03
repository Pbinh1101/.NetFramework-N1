using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWinform.Entities
{
    public class Historystudy
    {
        public string Cap { get; set; }
        public string Truonghoc { get; set; }
        public float DiemTB { get; set; }
        public string Hanhkiem { get; set; }

        public static List<Historystudy> GetList()
        {
            var ds = new List<Historystudy>();
            ds.Add(new Historystudy
            {
                Cap = "Cấp 1",
                Truonghoc = "Trường Tiểu học số 2 Hương Xuân",
                DiemTB = 8f,
                Hanhkiem = "Tốt"
            });
            ds.Add(new Historystudy
            {
                Cap = "Cấp 2",
                Truonghoc = "Trường Trung học cơ sở Nguyễn Khánh Toàn",
                DiemTB = 7.9f,
                Hanhkiem = "Tốt"
            });
            ds.Add(new Historystudy
            {
                Cap = "Cấp 3",
                Truonghoc = "Trường Trung học phổ thông Đăng Huy Trứ",
                DiemTB = 8.0f,
                Hanhkiem = "Tốt"
            });
            return ds;
        }

        public static Historystudy Get(string cap)
        {
            var dbHistory = GetList();
            var history = dbHistory.Where(p => p.Cap == cap).FirstOrDefault();
            return history;
        }
    }
}