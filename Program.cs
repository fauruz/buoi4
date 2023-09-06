using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    class Program
    {
        public static void Main()
        {
            ToaDo o = new ToaDo("O",5,5);
            HinhTron ht = new HinhTron(o,10.5);
            double cv = ht.tinhChuVi();
            double dt = ht.tinhDienTich();
            Console.WriteLine("Hinh tron co tam {0} voi ban kinh {1} co dien tich va chu vi lan luot la {2} va {3}",o,ht.BanKinh,cv,dt);
            Console.ReadLine();
        }
    }
}