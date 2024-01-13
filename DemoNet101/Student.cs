using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet101
{
    public class Student
    {
        //dac diem
        private string HoTen { get; set; }
        private double Diem { get; set; }

        //contructor
        public Student() 
        {
        }
        public Student(string hoTen)
        {
            this.HoTen = hoTen;
        }
        public Student(string hoTen, double diem)
        {
            this.HoTen = hoTen;
            this.Diem = diem;
        }


        //hanh dong
        public void Nhap()
        {
            this.Diem = Diem;
        }
        public void Xuat() 
        { 
            Console.WriteLine("Ho Ten:" + HoTen + " Diem: " + Diem + "Hoc Luc: " +XepLoaiHocLuc());
        }
        public string XepLoaiHocLuc()
        {
            string hocluc;
            if (Diem < 5)
            {
                hocluc = "Yeu";
            }else if (Diem > 5 && Diem <= 6.5)
            {
                hocluc = "trung binh";
            }else if(Diem > 6.5 && Diem < 8)
            {
                hocluc = "kha";
            }
            else
            {
                hocluc = "gioi";
            }
            return hocluc;
        }
    }
}
