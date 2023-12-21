Console.Write("Enter a number: ");
int a = int.Parse(Console.ReadLine()!);
int firstDigit;
int lastDigit;
int sum;

firstDigit = a / 100;
lastDigit = a % 10;
sum = firstDigit + lastDigit;
Console.WriteLine(sum);

