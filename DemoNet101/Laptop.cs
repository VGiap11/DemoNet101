using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet101
{

    // Class => dday la doi tuong laptop
    public class Laptop
    {

        // đặc điểm của laptop
        public int Id { get; set; }

        public string NameMayTinh { get; set; }

        public string ManHinh { get; set; }

        public string BanPhim { get; set; }

        public string Ram {get; set; }

        public double KhoiLuong {  get; set; }
        //


        // cac hanh dong cua laptop
        public void BatMayTinh( int id)
        {
            Console.WriteLine("Dang bat may tinh:" + id);
        }

        public void TatMayTinh(int id)
        {
            Console.WriteLine("Dang Tat May Tinh: " + id);
        }
        

        public void Display()
        {
            Console.WriteLine("Ten May Tinh: " + NameMayTinh + " Man Hinh: " + ManHinh + "Ban Phim " + BanPhim + "Ram: " + Ram + "Khoi luong:" + KhoiLuong);
        }
        //
    }
}
