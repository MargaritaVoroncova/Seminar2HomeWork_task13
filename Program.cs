// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int constantaNumber = 3;
int userNumber = new int();

Console.WriteLine("Введите число  ");
userNumber = Convert.ToInt32(Console.ReadLine ());

if(userNumber<100 && userNumber> -100)
{
    Console.WriteLine($"у числа {userNumber} нет третьей цифры");
}
else
{
 String   userNumberString = userNumber.ToString();
 int lengthUserNumberString = userNumberString.Length;
 Console.WriteLine($"третья цифра этого числа: {userNumberString[constantaNumber-1]}");
}

