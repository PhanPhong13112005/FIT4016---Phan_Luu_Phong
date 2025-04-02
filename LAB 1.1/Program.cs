//Bài 1:Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào [tên], bạn[tuổi] tuổi!".

using System.Text;

int tuoi;
string ten;
Console.WriteLine("Nhập tên: ");
ten = Console.ReadLine();
Console.WriteLine("Nhập tuổi: ");
tuoi = int.Parse(Console.ReadLine());
Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");

//Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và chiều rộng.

int chieudai, chieurong;
Console.WriteLine("Nhập chiều dài: ");
chieudai = int.Parse(Console.ReadLine());
Console.WriteLine("Nhập chiều rộng: ");
chieurong = int.Parse(Console.ReadLine());
Console.WriteLine($"Diện tích hình chữ nhật là: {chieudai * chieurong}");

//Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F Công thức: F = (C * 9 / 5) + 32

int doC;
Console.WriteLine("Nhập độ C: ");
doC = int.Parse(Console.ReadLine());
Console.WriteLine($"Độ F là: {(doC * 9 / 5) + 32}");

//Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn hay không.

int so;
Console.WriteLine("Nhập số: ");
so = int.Parse(Console.ReadLine());
if (so % 2 == 0)
{
    Console.WriteLine("Số chẵn");
}
else
{
    Console.WriteLine("Số lẻ");
}

//Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.

int a, b;
Console.WriteLine("Nhập số a: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Nhập số b: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine($"Tổng: {a + b}");
Console.WriteLine($"Tích: {a * b}");

//Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số không.

int nhap;
Console.WriteLine("Nhập số: ");
nhap = int.Parse(Console.ReadLine());
if (so > 0)
{
    Console.WriteLine("Số dương");
}
else if (nhap < 0)
{
    Console.WriteLine("Số âm");
}
else
{
    Console.WriteLine("Số không");
}
//Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không. (Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho 400).

int nam;
Console.WriteLine("Nhập năm: ");
nam = int.Parse(Console.ReadLine());
if (nam % 4 == 0 && nam % 100 != 0 || nam % 400 == 0)
{
    Console.WriteLine("Năm nhuận");
}
else
{
    Console.WriteLine("Không phải năm nhuận");
}

//Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10.

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
}

//Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n.

int n;
Console.WriteLine("Nhập số n: ");
n = int.Parse(Console.ReadLine());
int giaithua = 1;
for (int i = 1; i <= n; i++)
{
    giaithua *= i;
}
Console.WriteLine($"Giai thừa của {n} là: {giaithua}");
for (int i = 1;
    i <= 10;
    i++)
{
    for (int j = 1;
        j <= 10;
        j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
}

// Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.

int sonhap;
Console.WriteLine("Nhập số: ");
sonhap = int.Parse(Console.ReadLine());
if (sonhap < 2)
{
    Console.WriteLine("Không phải số nguyên tố");
}
else
{
    bool check = true;
    for (int i = 2; i <= Math.Sqrt(sonhap); i++)
    {
        if (sonhap % i == 0)
        {
            check = false;
            break;
        }
    }
    if (check)
    {
        Console.WriteLine("Là số nguyên tố");
    }
    else
    {
        Console.WriteLine("Không phải số nguyên tố");
    }
}   

