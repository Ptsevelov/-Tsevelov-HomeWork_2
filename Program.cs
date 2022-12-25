//Задача 1 
/*Console.WriteLine("Введите трехзначное число");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 >= 100 && num1 <1000 )
{
    Console.WriteLine("Это трехзначное число");
}
else
{
    Console.WriteLine("Это не трехзначное число");
}
string num2 = Convert.ToString(num1);
Console.WriteLine($"вторая цифра этого числа -> "+num2[1]);
*/

//Задача 2

/*Console.Write("Введи число: ");
int num11 = Convert.ToInt32(Console.ReadLine());
string num21 = Convert.ToString(num11);
if (num21.Length > 2){
  Console.WriteLine("третья цифра -> " + num21[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}*/

//Задача 3 

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());


  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Этот день выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Это не день недели");
  }
  else Console.WriteLine("Этот день не выходной");



