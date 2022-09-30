// // Вид 1. Метод, который ничего не возвращает и ничего не принимает
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }

// //Method1();  // Вывод метода

// // Вид 2. Метод, который не возвращает, но принимает
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// //Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//         //break; приостановка цикла
//     }
   
// }

// //Method21("Четыре", 4); // Выводим слово текст 4 раза. 
// //Method21(count: 5, msg:"Пять"); // Можно написать в скобках с конкретным указанием, что содержится в переменной без соблюдения очерёдности

// //Вид 3. Что-то возвращяют, но ничего не принимают.

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// // int year = Method3();
// // Console.WriteLine(year);

// // Вид 4. Метод, который принимает и возвращает
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// // string res = Method4(10, "qwerty");
// // Console.Write(res);


// //Пример цикла for:

// // for (int i = 0; i <= 10; i++)
// // {
// //     Console.WriteLine(i);
// // }


// string Method42(int count, string text)
// {
//     string result = String.Empty;

//     for (int i = 0; i <= count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// // string res = Method42(10, "z");
// // Console.Write(res);


// Цикл внутри цикла

// int i = 2;
// int j = 2;

// void Method5()
// {
//     for(int i = 2; i <= 10; i++);
//     {
        // for(int j = 2; j <= 10; j++);
        // {
        //     Console.WriteLine(j);
        // }
//         Console.WriteLine();
// //     }
// }

// Таблица умножения

for (int i = 2; i <= 10; i++)
{
                for(int j = 2; j <= 10; j++)
        {
            Console.WriteLine($" {i} * {j} = {i * j}");
        }
        Console.WriteLine();
}




// ДЛЯ ВЕРОНИКИ
// int a = 1020; 
// int z = 32;
// int rezult = a * z;
// Console.WriteLine(rezult = a * z);
