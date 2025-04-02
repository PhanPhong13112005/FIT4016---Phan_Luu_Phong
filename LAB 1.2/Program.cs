//Bài 1: Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng.

void SumEven(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            sum += arr[i];
        }
    }
    Console.WriteLine($"Tổng các số chẵn trong mảng là: {sum}");
}



//Bài 2: Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím. Viết hàm để kiểm
//tra xem một số có phải là số nguyên tố hay không, hiển thị chỉ số và giá trị của những phần tử
//là số nguyên tố trong mảng.

void CheckPrime(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 2)
        {
            Console.WriteLine($"Phần tử thứ {i} có giá trị {arr[i]} không phải là số nguyên tố");
        }
        else
        {
            int count = 0;
            for (int j = 2; j <= Math.Sqrt(arr[i]); j++)
            {
                if (arr[i] % j == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"Phần tử thứ {i} có giá trị {arr[i]} là số nguyên tố");
            }
            else
            {
                Console.WriteLine($"Phần tử thứ {i} có giá trị {arr[i]} không phải là số nguyên tố");
            }
        }
    }
}
//Bài 3: Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập
//từ bàn phím.

void CountNegativePositive(int[] arr)
{
    int countNegative = 0;
    int countPositive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            countNegative++;
        }
        else if (arr[i] > 0)
        {
            countPositive++;
        }
    }
    Console.WriteLine($"Số lượng số âm trong mảng là: {countNegative}");
    Console.WriteLine($"Số lượng số dương trong mảng là: {countPositive}");
}
//Bài 4: Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên.

void SecondLargest(int[] arr)
{
    int max = arr[0];
    int secondMax = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            secondMax = max;
            max = arr[i];
        }
        else if (arr[i] > secondMax && arr[i] < max)
        {
            secondMax = arr[i];
        }
    }
    Console.WriteLine($"Số lớn thứ hai trong mảng là: {secondMax}");
}
//Bài 5: Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím.

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
//Bài 6: Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần.

static void SortArray(double[] numbers)
{
    Array.Sort(numbers);
}

static void Main()
{
    Console.Write("Nhập số phần tử của mảng: ");
    int n = int.Parse(Console.ReadLine());
    double[] array = new double[n];

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Nhập phần tử thứ {i + 1}: ");
        array[i] = double.Parse(Console.ReadLine());
    }

    SortArray(array);

    Console.WriteLine("Mảng sau khi sắp xếp:");
    foreach (double num in array)
    {
        Console.Write(num + " ");
    }
}


