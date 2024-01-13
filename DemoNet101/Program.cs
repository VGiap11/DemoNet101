using System;
using System.Collections;

namespace DemoNet101
{
    public class Program
    {
        static void Main(string[] args)
        {
           //Laptop lp = new Laptop();
           // lp.Id = 1;
           // Console.WriteLine("Nhap ten may tinh: ");
           // lp.NameMayTinh = Console.ReadLine();
           // Console.WriteLine("Nhap man hinh: ");
           // lp.ManHinh = Console.ReadLine();
           // Console.WriteLine("Nhap ban Phim: ");
           // lp.BanPhim = Console.ReadLine();
           // Console.WriteLine("Nhap ram: ");
           // lp.Ram = Console.ReadLine();
           // Console.WriteLine("Nhap khoi luong: ");
           // lp.KhoiLuong = Convert.ToDouble(Console.ReadLine()); 

           // lp.BatMayTinh(lp.Id);
           // lp.TatMayTinh(lp.Id);
           // lp.Display();

           
            //student.Nhap();
            Console.WriteLine("Nhap Ho va Ten:");
            string name = Console.ReadLine();
            
            Student student = new Student(name);
            student.Xuat();


            Console.ReadKey();
        }
    }
}
