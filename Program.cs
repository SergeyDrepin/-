// Проверка на полиндром

int[] array = { 1, 4, 2, 1, 2 };
int index = 0;
int size = array.Length;

if (array[index] == array(size - 1) && array[index + 1] == array(size - 2))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}


