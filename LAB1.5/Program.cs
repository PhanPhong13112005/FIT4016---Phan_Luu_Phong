using System;
using System.Collections.Generic;
using LAB1._5;

namespace SumFractions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hỗ trợ in tiếng Việt lên Console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo danh sách chứa các phân số
            List<PhanSo> danhSachPhanSo = new List<PhanSo>();

            Console.Write("Nhập số lượng phân số: ");
            int n = int.Parse(Console.ReadLine());

            // Nhập các phân số từ bàn phím
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập phân số thứ {i + 1}:");
                PhanSo ps = new PhanSo();
                ps.NhapPhanSo();
                danhSachPhanSo.Add(ps);
            }

            // Tính tổng các phân số trong danh sách
            // Khởi tạo tổng bằng 0/1
            PhanSo tong = new PhanSo(0, 1);
            foreach (var ps in danhSachPhanSo)
            {
                tong = PhanSo.CongPhanSo(tong, ps);
            }

            Console.WriteLine("Tổng các phân số trong danh sách là: " + tong);
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadLine();
        }
    }
}
