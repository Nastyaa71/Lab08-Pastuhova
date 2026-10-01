// int lessonNumber = 1;
// int totalLessons = 5;
// while (lessonNumber <= totalLessons)
// {
//     Console.WriteLine($"Пара {totalLessons}");
//     totalLessons = totalLessons - 1;
// }
// Console.WriteLine("Пары закончились");

// Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// int count = 0;
// while (grade != -1)
// {
//     Console.WriteLine($"Оценка принята: {grade}");
//     count++;
//     grade = int.Parse(Console.ReadLine());
// }
// Console.WriteLine("Ввод завершён. Всего введено оценок: {count}");

int sum = 0;
int count = 0;
Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());

// while (grade != -1)
// {
//     sum += grade;
//     count++;
//     grade = int.Parse(Console.ReadLine());
// }

if (count > 0)
{
    Console.WriteLine($"Средний балл: {(double)sum / count}");
}
else
{
    Console.WriteLine("Оценок не было введено");
}

string correctPassword = "qwerty123";
while (true)
{
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешен");
        break;
    }

    Console.WriteLine("Неверный пароль, попробуйте снова");
} 

