// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите число --> ");
int number = Convert.ToInt32(Console.ReadLine());

int TableOfCubes(int num){
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index}  {index*index*index}");
        index++;
    }
    return index;
}
int tableOfCubes = TableOfCubes(number);
Console.WriteLine($"{tableOfCubes}");

// Если делать через void, то тогда дополнительной цифры в конце нету. Но в моем варианте выходит что добавляется 
// еще одно число index. Мог написать правильно, но хочу разобраться в чем дело.