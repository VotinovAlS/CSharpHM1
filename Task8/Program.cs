Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;

if (N > 0)
{

  if (N < 2)
  {
    Console.Write("Четных чисел нет");
    count = N;
  }
  else
  {
    while (count < N - 1)
    {
      count = count + 2;
      Console.Write(count + " ");
    }
  }

}
else
{

  if (N > -2)
  {
    Console.Write("Четных чисел нет");
    count = N;
  }
  else
  {
    while (count > N + 1)
    {
      count = count - 2;
      Console.Write(count + " ");
    }
  }

}
