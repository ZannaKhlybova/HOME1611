//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*int AboveZero(int m)
{ 
int col=0;
for(int i=0;i<m;i++)
{
    Console.Write("input a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number>0)
    col++;
}
return col;
}
Console.Write("please,enter number of numbers: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"number of numbers greater than zero = {AboveZero(n)}");
*/
//Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
void IntersectionPoint(double k1,double b1,double k2,double b2)
{
if(k1==k2 && b1==b2)
{
Console.WriteLine("прямые совпадают и задача имеет бесконечное множество решений");
}
else if (k1==k2)
     {
     Console.WriteLine("прямые параллельны и задача не имеет решения");
     }
     else
        {
        double x = (b2-b1) / (k1-k2);
        double y = k1*x+b1;
        Console.WriteLine($"координаты точки пересечения прямых ({x} ; {y})");
        }
}
Console.WriteLine("найдём точку пересечения двух прямых");
Console.Write("введите,пожалуйста коэффициент к1 :");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите,пожалуйста,свободный член b1 :");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите,пожалуйста коэффициент к2 :");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите,пожалуйста,свободный член b2 :");
double b2 = Convert.ToDouble(Console.ReadLine());
IntersectionPoint(k1,b1,k2,b2);
