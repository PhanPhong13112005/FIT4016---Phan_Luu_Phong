using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1._5
{
    public class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        // Constructor mặc định
        public PhanSo() { }

        // Constructor khởi tạo với giá trị tử số và mẫu số
        public PhanSo(int tuSo, int mauSo)
        {
            TuSo = tuSo;
            MauSo = mauSo;
        }

        // Phương thức nhập phân số từ bàn phím
        public void NhapPhanSo()
        {
            Console.Write("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());
            // Kiểm tra mẫu số khác 0
            while (MauSo == 0)
            {
                Console.Write("Mẫu số không được bằng 0. Nhập lại mẫu số: ");
                MauSo = int.Parse(Console.ReadLine());
            }
        }

        // Phương thức cộng 2 phân số và trả về kết quả dưới dạng một đối tượng PhanSo mới
        public static PhanSo CongPhanSo(PhanSo ps1, PhanSo ps2)
        {
            // Cộng phân số theo công thức:
            // a/b + c/d = (a*d + c*b)/(b*d)
            int tu = ps1.TuSo * ps2.MauSo + ps2.TuSo * ps1.MauSo;
            int mau = ps1.MauSo * ps2.MauSo;
            PhanSo ketQua = new PhanSo(tu, mau);
            ketQua.RutGon();
            return ketQua;
        }

        // Phương thức rút gọn phân số bằng cách chia cả tử số và mẫu số cho ước chung lớn nhất (UCLN)
        public void RutGon()
        {
            int ucln = UCLN(Math.Abs(TuSo), Math.Abs(MauSo));
            TuSo /= ucln;
            MauSo /= ucln;
        }

        // Hàm tính ước chung lớn nhất (UCLN) của 2 số
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }

        // Ghi đè phương thức ToString để in phân số theo dạng "tử số/mẫu số"
        public override string ToString()
        {
            return $"{TuSo}/{MauSo}";
        }
    }

}
