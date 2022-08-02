
//int x = 100 / 50;
//int sum1 = 100 + 50;
//int sum2 = sum1 + 250;
//int sum3 = sum2 + sum1;
//sum3++;
//sum3 = sum3 + 1;
//sum3--;
//sum3 = sum3 - 1;
//x = 5;
//x += 5;
//x = x + 5;
//x -= 5;
//x = x - 5;
//x *= 5;
//x = x * 5;
//x /= 5;
//x = x / 5;

//-6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15
int num = -6;

double xx = -6 * Math.Pow(num, 3) + 5 * Math.Pow(num, 2) - 10 * num + 15;
Console.WriteLine(xx);

int num1 = 5;
double xxx = Math.Abs(num) * Math.Sin(num);
Console.WriteLine(xxx);

//2 * pi * x

int num2 = -6;

double xxx2 = 2 * Math.PI * num2;
Console.WriteLine(xxx2);

int num3 = 32;
int num4 = -6;
double xxx3 = Math.Max(num3, num4);
Console.WriteLine(xxx3);


var currentDate = DateTime.Now;
var newYearDate = new DateTime(currentDate.Year + 1, 1, 1);
var toNewYear = newYearDate - currentDate;
Console.WriteLine($"До нового года осталось {toNewYear.Days} дней");


DateTime finishYear = new DateTime(2023, 1, 1);
TimeSpan dateLeft = finishYear - DateTime.Now;
Console.WriteLine($"{dateLeft.Days} дней прошло с Нового Года");
