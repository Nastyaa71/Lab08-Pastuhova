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

string answer;

do
{
    Console.WriteLine("Введите дату посещения(например, 01.09): ");
    string date = Console.ReadLine();
    Console.WriteLine($"Запись добавлена: {date}");

    Console.WriteLine("Добавить ещё одну запись? (да/нет): ");
    answer = Console.ReadLine();
} while (answer == "да");

Console.WriteLine("Дневник сохранён");

int N = 5;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{N} * {i} = {N * i}");
}

while (true)
{
    Console.Write("Введите целое число: ");
    int numberr = int.Parse(Console.ReadLine());

    if (numberr % 7 == 0)
    {
        Console.WriteLine("Найдено!");
        break;
    }
}

Console.WriteLine("Введите свою фамилию");
string surname = Console.ReadLine()!.Trim();

if (string.IsNullOrEmpty(surname))
{
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}

Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

var assigned = Enumerable.Range(1,10)
    .OrderBy(_ => rnd.Next())
    .Take(2)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

int summ = 0;
int number;

Console.WriteLine("Вводите целые числа. Для завершения введите 0.");

do
{
    Console.Write("Введите число: ");
    number = int.Parse(Console.ReadLine());

    if (number > 0)
    {
        summ += number;
    }

} while (number != 0);

Console.WriteLine($"Сумма положительных чисел: {summ}");

Console.WriteLine("Задача 7");

double sum7 = 0;

for (int day = 1; day <= 7; day++)
{
    Console.Write($"Введите температуру за {day}-й день: ");
    double temperature7 = double.Parse(Console.ReadLine()!);

    sum7 += temperature7;
}

double average7 = sum7 / 7;

Console.WriteLine($"Средняя температура за неделю: {average7:F2}");

