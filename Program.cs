// Функция вывода массива на экран
void PrintArray(string[] array)
{   if(array.Length == 0)
    {
        System.Console.WriteLine("[]");
    }
    else
    {
        System.Console.Write(array[0]);             // Вывод 1-го элемента массива
        for (int i = 1; i < array.Length; i++)
        {
            System.Console.Write($", {array[i]}");  // Вывод текущего элемента массива
        }
        System.Console.WriteLine();     
    }
                // Перевод строки (чтобы отделять массивы)
}


string[] ThreeDigitMassive(string[] Massive)

{   
    string[] NewMassive = new string[Massive.Length];
    int ItemLength = 0;
    int count = 0;
    for(int i = 0; i < Massive.Count(); i++)
    {        
        ItemLength = Massive[i].Length;
        // Console.WriteLine(m);
          
        if(ItemLength > 0 && ItemLength <= 3)
        {
            NewMassive[count] = Massive[i];
            count += 1;
        }
            
    }
    Array.Resize(ref NewMassive, count);
    return NewMassive;           
}

string[] massive = new[] {"Hello", "2", "world", ":-)"};
// string[] massive = {"1234", "1567", "-2", "computer spaice", "Thu", "Fri", "Sat"};
PrintArray(massive); // выводим массив в консоль
string[] arr = ThreeDigitMassive(massive);
PrintArray(arr);
