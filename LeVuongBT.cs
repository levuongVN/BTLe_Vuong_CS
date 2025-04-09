// // Bài 1: Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào
// // [tên], bạn [tuổi] tuổi!".
// void ProcessB1()
// {
//     Console.WriteLine("Enter name: ");
//     String strName = Console.ReadLine() ?? null;
//     Console.WriteLine("Enter age: ");
//     int intAge = int.Parse(Console.ReadLine() ?? null);
//     if (intAge == null || strName == null)
//     {
//         Console.WriteLine("Invalid input");
//         return;
//     }
//     Console.WriteLine($"Hello {strName}, you are {intAge} years old!");
// }
// // ProcessB1();

// // Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và
// // chiều rộng
// void ProcessB2()
// {
//     Console.WriteLine("Enter length: ");
//     int intLength = int.Parse(Console.ReadLine() ?? null);
//     Console.WriteLine("Enter width: ");
//     int intWidth = int.Parse(Console.ReadLine() ?? null);
//     if (intLength == null || intWidth == null)
//     {
//         Console.WriteLine("Invalid input");
//         return;
//     }
//     Console.WriteLine($"Area of rectangle: {intLength * intWidth}");
// }
// // ProcessB2();

// // Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
// // Công thức: F = (C * 9/5) + 32
// void ProcessB3()
// {
//     Console.WriteLine("Enter temperature in Celsius: ");
//     double dblCelsius = double.Parse(Console.ReadLine() ?? null);
//     if (dblCelsius == null)
//     {
//         Console.WriteLine("Invalid input");
//         return;
//     }
//     double dblFahrenheit = (dblCelsius * (9/5)) + 32;
//     Console.WriteLine($"Temperature in Fahrenheit: {dblFahrenheit}");
// }
// // ProcessB3();

// // Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn
// // hay không.
// void ProcessB4()
// {
//     Console.WriteLine("Enter a number: ");
//     int intNumber = int.Parse(Console.ReadLine() ?? null);
//     if (intNumber == null)
//     {
//         Console.WriteLine("Invalid input");
//         return;
//     }
//     if (intNumber % 2 == 0)
//     {
//         Console.WriteLine($"{intNumber} is an even number");
//     }
//     else
//     {
//         Console.WriteLine($"{intNumber} is an odd number");
//     }
// }
// // ProcessB4();

// // Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.
// void ProcessB5()
// {
//     Console.WriteLine("Enter first number: ");
//     int intNumber1 = int.Parse(Console.ReadLine() ?? null);
//     Console.WriteLine("Enter second number: ");
//     int intNumber2 = int.Parse(Console.ReadLine() ?? null);
//     if (intNumber1 == null || intNumber2 == null)
//     {
//         Console.WriteLine("Invalid input");
//         return;
//     }
//     int intSum = intNumber1 + intNumber2;
//     int intProduct = intNumber1 * intNumber2;
//     Console.WriteLine($"Sum: {intSum}");
//     Console.WriteLine($"Product: {intProduct}");
// }
// // ProcessB5();

// // Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số
// // không.
// void ProcessB6()
// {
//     Console.WriteLine("Enter a number: ");
//     int intNumber = int.Parse(Console.ReadLine() ?? null);
//     if (intNumber == null)
//     {
//         Console.WriteLine("Invalid input");
//         return;
//     }
//     if (intNumber > 0)
//     {
//         Console.WriteLine($"{intNumber} is a positive number");
//     }
//     else if (intNumber < 0)
//     {
//         Console.WriteLine($"{intNumber} is a negative number");
//     }
//     else
//     {
//         Console.WriteLine($"{intNumber} is zero");
//     }
// }
// // ProcessB6();

// // Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
// // (Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho
// // 400).
// void ProcessB7()
// {
//     Console.WriteLine("Enter a year: ");
//     int intYear = int.Parse(Console.ReadLine() ?? null);
//     if (intYear == null)
//     {
//         Console.WriteLine("Invalid input");
//         return;
//     }
//     if ((intYear % 4 == 0 && intYear % 100 != 0) || intYear % 400 == 0)
//     {
//         Console.WriteLine($"{intYear} is a leap year");
//     }
//     else
//     {
//         Console.WriteLine($"{intYear} is not a leap year");
//     }
// }
// // ProcessB7();

// // Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10.
// void ProcessB8()
// {
//     for (int i = 1; i <= 10; i++)
//     {
//         Console.WriteLine($"Multiplication table of {i}:");
//         for (int j = 1; j <= 10; j++)
//         {
//             Console.Write($"{i} * {j} = {i * j}\t");
//         }
//         Console.WriteLine();
//     }
// }
// // ProcessB8();

// // Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n.
// void FactorialB9(){
//     Console.Write("Enter a number: ");
//     int number = int.Parse(Console.ReadLine()?? null);
//     if(number == null || number < 0){
//         Console.WriteLine("Invalid input");
//         return;
//     }
//     long factorial = 1;
//     for(int i = 1; i <= number; i++){
//         factorial *= i;
//     }
//     Console.WriteLine($"Factorial of {number} is {factorial}");
// }
// // FactorialB9();

// // Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.
// void PrimeNumberB10(){
//     Console.Write("Enter a number: ");
//     int number = int.Parse(Console.ReadLine()?? null);
//     if(number == null || number < 2){
//         Console.WriteLine("Invalid input");
//         return;
//     }
//     bool isPrime = true;
//     for(int i = 2; i <= Math.Sqrt(number); i++){
//         if(number % i == 0){
//             isPrime = false;
//             break;
//         }
//     }
//     if(isPrime){
//         Console.WriteLine($"{number} is a prime number");
//     }else{
//         Console.WriteLine($"{number} is not a prime number");
//     }
// }
// PrimeNumberB10();

// LAB 2:
// Bài 1: Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng.
void Sum()
{
    Console.WriteLine("Enter number elm: ");
    int n = int.Parse(Console.ReadLine() ?? null);
    int sum = 0;
    int[] Arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Enter number of elm: Arr[{i + 1}]: ");
        Arr[i] = int.Parse(Console.ReadLine() ?? null);
        if (Arr[i] % 2 == 0)
        {
            sum += Arr[i];
        }
    }
    System.Console.WriteLine($"The sum is:{sum}");
}
// Sum();

// Bài 2: Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím. Viết hàm để kiểm 
// tra xem một số có phải là số nguyên tố hay không, hiển thị chỉ số và giá trị của những phần tử
// là số nguyên tố trong mảng.
void PrimeNumber()
{
    Console.Write("Nhập số lượng phần tử mảng (n): ");
    int n = int.Parse(Console.ReadLine());

    // Khởi tạo mảng
    int[] arr = new int[n];

    // Nhập các phần tử mảng
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Nhập phần tử thứ {i + 1}: ");
        arr[i] = int.Parse(Console.ReadLine());
    }

    // Kiểm tra và hiển thị số nguyên tố
    Console.WriteLine("\nCác số nguyên tố trong mảng:");
    bool foundPrime = false;
    for (int i = 0; i < n; i++)
    {
        if (IsPrime(arr[i]))
        {
            Console.WriteLine($"Chỉ số: {i+1}, Giá trị: {arr[i]}");
            foundPrime = true;
        }
    }

    if (!foundPrime)
    {
        Console.WriteLine("Không tìm thấy số nguyên tố nào trong mảng!");
    }

}
static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    for (int i = 3; i <= Math.Sqrt(number); i += 2)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}
// PrimeNumber();


// Bài 3: Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập 
// từ bàn phím.
void DemVaHienThiSoAmDuong()
{
    // Nhập mảng
    Console.Write("Nhập số lượng phần tử: ");
    int n = int.Parse(Console.ReadLine());
    
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Nhập phần tử thứ {i + 1}: ");
        arr[i] = int.Parse(Console.ReadLine());
    }

    // Đếm số âm/dương
    int soAm = 0, soDuong = 0;
    foreach (int num in arr)
    {
        if (num < 0) soAm++;
        else if (num > 0) soDuong++;
    }

    // Hiển thị kết quả
    Console.WriteLine($"Số âm: {soAm}");
    Console.WriteLine($"Số dương: {soDuong}");
}
DemVaHienThiSoAmDuong();

int? TimSoLonThuHai(int[] arr)
{
    if (arr == null || arr.Length < 2)
        return null;

    int max1 = Math.Max(arr[0], arr[1]);
    int max2 = Math.Min(arr[0], arr[1]);

    for (int i = 2; i < arr.Length; i++)
    {
        if (arr[i] > max1)
        {
            max2 = max1;
            max1 = arr[i];
        }
        else if (arr[i] > max2 && arr[i] != max1)
        {
            max2 = arr[i];
        }
    }

    return max2 != max1 ? max2 : null;
}
// int[] numbers = { 5, 8, 2, 8, 3, 10 };
// int? result = TimSoLonThuHai(numbers);

// if (result.HasValue)
//     Console.WriteLine($"Số lớn thứ hai là: {result.Value}");
// else
//     Console.WriteLine("Không tìm thấy số lớn thứ hai");

// Bài 5: Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím.
void HoanVi(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
int x = 5, y = 10;
// HoanVi(ref x, ref y);

// Bài 6: Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần.
void SapXepTangDan(double[] arr)
{
    Array.Sort(arr);
}
double[] mang = { 2.5, 1.3, 4.7 };
// SapXepTangDan(mang);

