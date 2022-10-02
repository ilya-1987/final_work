// Функция определения элементов массива где количество символов 3 и меньше
void methodArray (string [] array){
     string[] newarr = new string[array.Length];
      for (int i=0; i<array.Length; i++){      
        if(array[i].Length<=3){
          newarr[i]=array[i];
          System.Console.Write(newarr[i]+" "); 
        }
        
      }
}
// Функция вывода массива
void Print(string [] Array)
{
     for (int i=0; i<Array.Length; i++){
        System.Console.Write(Array[i]+" ");
    }
}
// Заполняем массив с клавиатуры
System.Console.WriteLine("Заполните массив: ");
      string[] array; // ссылка на массив строк
      int count; // текущее количество строк в массиве
      string s;
      string[] array2; // дополнительная переменная-ссылка - сохраняет старый массив строк

     count = 0; // обнулить количество строк
      array = new string[count]; // выделить память для 0 строк

      do
      {
        // Ввести строку
        s = System.Console.ReadLine();

        // Проверка, пустая ли строка
        if (s!="")
        {
          // если строка не пустая, то добавить строку в массив
          count++;

          // предварительно выделить память для нового массива
          // в котором на 1 элемент больше
           array2 = new string[count];

          // скопировать старый массив в новый
            for (int i = 0; i < array2.Length - 1; i++)
            array2[i] = array[i];

          // добавить последнюю введенную строку в массив  array2
            array2[count - 1] = s;

         // перенаправить ссылку  array на  array2
            array = array2;
        }
      } while (s != "");

// Вывод заполненного массива
System.Console.WriteLine("Вы ввели массив: ");
Print(array);
System.Console.WriteLine($"\n");
// Вывод элементов первого массива где количество символов три и меньше
System.Console.WriteLine("Элементы массива содержащие 3 и менее символов: ");
methodArray(array);
System.Console.WriteLine($"\n");