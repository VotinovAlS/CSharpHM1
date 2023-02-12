Console.Write("Для проверки числа на четность введите его: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 % 2 == 0)
{
  Console.WriteLine("да");
}
else
{
  Console.WriteLine("нет");
}