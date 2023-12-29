using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptrinhOOP
{
    class rectangle
    {
        private double length;
        private double width;
        public rectangle()
        {
            length = 1.0;
            width = 1.0;
        }
        public rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public void setLength(double length)
        {
            this.length = length;
        }
        public double getLength()
        {
            return length;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }
        public double getWidth()
        {
            return width;
        }
        public double findArea()
        {
            return length * width;
        }
        public double findPermeter()
        {
            return (length + width) * 2;
        }
    }
        class Programbaitap01
        {
            static void Main(string[] args)
            {
            rectangle r1; //Khai báo r1
            rectangle r2; //Khai báo r2
            r1 = new rectangle(); //Khởi tạo r1
            Console.Write(" Cho biet chieu dai:");
            double length = double.Parse(Console.ReadLine());
            Console.Write(" Cho biet chieu rong:");
            double width = double.Parse(Console.ReadLine()); ;
            r2 = new rectangle(length, width); //Khoi tao r2
            Console.WriteLine("------Thong tin hinh chu nhat r1-------");
            Console.WriteLine(" Chieu dai: {0}\nChieu rong: {1}\nDien tich: {3}",
                r1.getLength(),r1.getWidth(),r1.findArea(),r1.findPermeter());
            Console.WriteLine("------Thong tin hinh chu nhat r2-------");
            Console.WriteLine(" Chieu dai: {0}\nChieu rong: {1}\nDien tich: {3}",
                r2.getLength(), r2.getWidth(), r2.findArea(), r2.findPermeter());
            Console.ReadLine();
        }
        }
    }

