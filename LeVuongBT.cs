// Bài 1: Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào
// [tên], bạn [tuổi] tuổi!".
void ProcessB1()
{
    Console.WriteLine("Enter name: ");
    String strName = Console.ReadLine() ?? null;
    Console.WriteLine("Enter age: ");
    int intAge = int.Parse(Console.ReadLine() ?? null);
    if (intAge == null || strName == null)
    {
        Console.WriteLine("Invalid input");
        return;
    }
    Console.WriteLine($"Hello {strName}, you are {intAge} years old!");
}
// ProcessB1();

// Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và
// chiều rộng
void ProcessB2()
{
    Console.WriteLine("Enter length: ");
    int intLength = int.Parse(Console.ReadLine() ?? null);
    Console.WriteLine("Enter width: ");
    int intWidth = int.Parse(Console.ReadLine() ?? null);
    if (intLength == null || intWidth == null)
    {
        Console.WriteLine("Invalid input");
        return;
    }
    Console.WriteLine($"Area of rectangle: {intLength * intWidth}");
}
// ProcessB2();

// Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
// Công thức: F = (C * 9/5) + 32
void ProcessB3()
{
    Console.WriteLine("Enter temperature in Celsius: ");
    double dblCelsius = double.Parse(Console.ReadLine() ?? null);
    if (dblCelsius == null)
    {
        Console.WriteLine("Invalid input");
        return;
    }
    double dblFahrenheit = (dblCelsius * (9/5)) + 32;
    Console.WriteLine($"Temperature in Fahrenheit: {dblFahrenheit}");
}
// ProcessB3();

// Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn
// hay không.
void ProcessB4()
{
    Console.WriteLine("Enter a number: ");
    int intNumber = int.Parse(Console.ReadLine() ?? null);
    if (intNumber == null)
    {
        Console.WriteLine("Invalid input");
        return;
    }
    if (intNumber % 2 == 0)
    {
        Console.WriteLine($"{intNumber} is an even number");
    }
    else
    {
        Console.WriteLine($"{intNumber} is an odd number");
    }
}
// ProcessB4();

// Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.
void ProcessB5()
{
    Console.WriteLine("Enter first number: ");
    int intNumber1 = int.Parse(Console.ReadLine() ?? null);
    Console.WriteLine("Enter second number: ");
    int intNumber2 = int.Parse(Console.ReadLine() ?? null);
    if (intNumber1 == null || intNumber2 == null)
    {
        Console.WriteLine("Invalid input");
        return;
    }
    int intSum = intNumber1 + intNumber2;
    int intProduct = intNumber1 * intNumber2;
    Console.WriteLine($"Sum: {intSum}");
    Console.WriteLine($"Product: {intProduct}");
}
// ProcessB5();

// Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số
// không.
void ProcessB6()
{
    Console.WriteLine("Enter a number: ");
    int intNumber = int.Parse(Console.ReadLine() ?? null);
    if (intNumber == null)
    {
        Console.WriteLine("Invalid input");
        return;
    }
    if (intNumber > 0)
    {
        Console.WriteLine($"{intNumber} is a positive number");
    }
    else if (intNumber < 0)
    {
        Console.WriteLine($"{intNumber} is a negative number");
    }
    else
    {
        Console.WriteLine($"{intNumber} is zero");
    }
}
// ProcessB6();

// Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
// (Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho
// 400).
void ProcessB7()
{
    Console.WriteLine("Enter a year: ");
    int intYear = int.Parse(Console.ReadLine() ?? null);
    if (intYear == null)
    {
        Console.WriteLine("Invalid input");
        return;
    }
    if ((intYear % 4 == 0 && intYear % 100 != 0) || intYear % 400 == 0)
    {
        Console.WriteLine($"{intYear} is a leap year");
    }
    else
    {
        Console.WriteLine($"{intYear} is not a leap year");
    }
}
// ProcessB7();

// Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10.
void ProcessB8()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"Multiplication table of {i}:");
        for (int j = 1; j <= 10; j++)
        {
            Console.Write($"{i} * {j} = {i * j}\t");
        }
        Console.WriteLine();
    }
}
// ProcessB8();

// Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n.
void FactorialB9(){
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine()?? null);
    if(number == null || number < 0){
        Console.WriteLine("Invalid input");
        return;
    }
    long factorial = 1;
    for(int i = 1; i <= number; i++){
        factorial *= i;
    }
    Console.WriteLine($"Factorial of {number} is {factorial}");
}
// FactorialB9();

// Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.
void PrimeNumberB10(){
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine()?? null);
    if(number == null || number < 2){
        Console.WriteLine("Invalid input");
        return;
    }
    bool isPrime = true;
    for(int i = 2; i <= Math.Sqrt(number); i++){
        if(number % i == 0){
            isPrime = false;
            break;
        }
    }
    if(isPrime){
        Console.WriteLine($"{number} is a prime number");
    }else{
        Console.WriteLine($"{number} is not a prime number");
    }
}
// PrimeNumberB10();