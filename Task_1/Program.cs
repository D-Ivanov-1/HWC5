//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

//1.Метод получения массива
//2.Создание массива
//3.Заполнение массива
//4.Печать массива
//5.Метод получения произведения чисел
//6.Метод вывода


Console.Clear();
//1. Считать от пользователя N
int GetNumberByUser(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}
//2. Создание массива
int[] CreateArray(int size)
{
    return new int[size];
}
//3. Заполнение
void Filling(int[] Array)
{
    int count = Array.Length;

    for (int i = 0; i < count; i++)
    {
        Array[i] = Random.Shared.Next(0,10);
    }
    
}

//4. Печать массива

string Print(int[] numbers)
{
string output = String.Empty;
int size = numbers.Length;

for (int i = 0; i < size; i++)
{
output = output + $" {numbers[i]},";
}
   return output;
}

//5.Метод получения произведения чисел

void PrintProductPairs(int[] dataArray)
{
    int last = dataArray.Length - 1;
    for (int i = 0; i < dataArray.Length / 2; i++)
    {
        System.Console.Write($"{dataArray[i] * dataArray[last]},", last-- );
    
    }
    if (dataArray.Length % 2 > 0) System.Console.WriteLine($"Число {dataArray[dataArray.Length / 2]} не имеет пары");
    System.Console.WriteLine();
}

//6. Метод вывода

void Task()
{
int countBuUser = GetNumberByUser("Введите колличество элементов в массиве N:");//1
int[] list = CreateArray(countBuUser);//2
Filling(list);//3
string Result = Print(list);//4
System.Console.WriteLine(Result);
System.Console.WriteLine();
PrintProductPairs(list);//5

}

Task();
