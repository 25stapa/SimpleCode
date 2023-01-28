/*
 *  Конвертация строки
 *  класс Convert
 */

 

// string str;
// int  a, b;

// Console.WriteLine("Input numbers 1 ");
// str = Console.ReadLine();
// a = Convert.ToInt32(str);

// Console.WriteLine("Input numbers 2 ");
// str = Console.ReadLine();
// b = Convert.ToInt32(str);

// int result = a + b;

// Console.WriteLine("Сумма чисел = " + result);


Console.WriteLine("Input first numbers ");
string a = Console.ReadLine();

int b = Convert.ToInt32(a);
Console.WriteLine("Input second numbers ");
string c = Console.ReadLine();
int d = Convert.ToInt32(c);
Console.WriteLine("result = " + (b+d));




// string str = "1,9";
// double a = Convert.ToDouble(str);

// Console.WriteLine(a);


//  Если вместо запятой будет точка, тогда на выводе в консоль будет ошибка. Тогда ...


// string str = "1.9";

// System.Globalization.NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
// {
//     NumberDecimalSeparator = ".",
// };

// double a = Convert.ToDouble(str, numberFormatInfo);

// Console.WriteLine(a);
