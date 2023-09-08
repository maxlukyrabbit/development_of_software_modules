using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { studentnumber = 1, Surname = "Sluchaev", name = "Maxim", patronymic = "Konstantinovich", yearbirth = "2005", studentclass = "9V", averagescore = 5.0},
            new Student { studentnumber = 2, Surname = "Spiridonov", name = "Evgeniy", patronymic = "Andreevich", yearbirth = "2005", studentclass = "9V", averagescore = 4.99},
            new Student { studentnumber = 3, Surname = "Patkov", name = "Dmitry", patronymic = "Andreevich", yearbirth = "2009", studentclass = "9A", averagescore = 4.0},
            new Student { studentnumber = 4, Surname = "Shavaliev", name = "Timur", patronymic = "Maratovich", yearbirth = "2005", studentclass = "9V", averagescore = 4.0},
            new Student { studentnumber = 5, Surname = "Funtova", name = "Sofi", patronymic = "Pavlovna", yearbirth = "2005", studentclass = "9V", averagescore = 4.4}
        };
        getinfo(students);

        System.Console.WriteLine($"_______________________________");

        var ListMax = students.Max(p => p.averagescore);
        var ListMin = students.Min(p => p.averagescore);

        System.Console.WriteLine($"Максимальный балл {ListMax}");
        System.Console.WriteLine($"Минимальный балл {ListMin}");

        System.Console.WriteLine($"_______________________________");


        var result9V = students
            .Where(p => p.studentclass == "9A");

        foreach (var student in result9V)
        {
            Console.WriteLine($"Номер: {student.studentnumber}");
            Console.WriteLine($"Фамилия: {student.Surname}");
            Console.WriteLine($"Имя: {student.name}");
            Console.WriteLine($"Отчество: {student.patronymic}");
            Console.WriteLine($"Год рождения: {student.yearbirth}");
            Console.WriteLine($"Класс: {student.studentclass}");
            Console.WriteLine($"Средний балл: {student.averagescore}");
            Console.WriteLine();
        }

        System.Console.WriteLine($"_______________________________");

        var result2009 = students
            .Where(p => p.yearbirth == "2009");

        foreach (var student in result2009)
        {
            Console.WriteLine($"Номер: {student.studentnumber}");
            Console.WriteLine($"Фамилия: {student.Surname}");
            Console.WriteLine($"Имя: {student.name}");
            Console.WriteLine($"Отчество: {student.patronymic}");
            Console.WriteLine($"Год рождения: {student.yearbirth}");
            Console.WriteLine($"Класс: {student.studentclass}");
            Console.WriteLine($"Средний балл: {student.averagescore}");
            Console.WriteLine();
        }

        System.Console.WriteLine($"_______________________________");

         var gr = students.GroupBy(args => args.studentclass); 

        foreach (var student in gr)
        {
            Console.WriteLine($"{student.Key} {student.Average(x => x.averagescore)}");
        }



        System.Console.WriteLine($"_______________________________");


        var FIO = students.Select(p => new { p.Surname, p.studentnumber });

        foreach (var student in FIO)
        {
            Console.WriteLine($"Фамилия: {student.Surname}");
            Console.WriteLine($"Номер: {student.studentnumber}");
            Console.WriteLine();
        }

        System.Console.WriteLine($"_______________________________");

        var sort = students.OrderBy(args => args.averagescore).ToList();

        foreach (var student in sort)
        {
            Console.WriteLine($"Номер: {student.studentnumber}");
            Console.WriteLine($"Фамилия: {student.Surname}");
            Console.WriteLine($"Имя: {student.name}");
            Console.WriteLine($"Отчество: {student.patronymic}");
            Console.WriteLine($"Год рождения: {student.yearbirth}");
            Console.WriteLine($"Класс: {student.studentclass}");
            Console.WriteLine($"Средний балл: {student.averagescore}");
            Console.WriteLine();
        }

        System.Console.WriteLine($"_______________________________");






    }

    static void getinfo(List<Student> students)
    {

        foreach (Student student in students)
        {
            Console.WriteLine($"Номер: {student.studentnumber}");
            Console.WriteLine($"Фамилия: {student.Surname}");
            Console.WriteLine($"Имя: {student.name}");
            Console.WriteLine($"Отчество: {student.patronymic}");
            Console.WriteLine($"Год рождения: {student.yearbirth}");
            Console.WriteLine($"Класс: {student.studentclass}");
            Console.WriteLine($"Средний балл: {student.averagescore}");
            Console.WriteLine();
        }
    }
}

class Student
{
    public int studentnumber { get; set; }
    public string Surname { get; set; }
    public string name { get; set; }
    public string patronymic { get; set; }
    public string yearbirth { get; set; }
    public string studentclass { get; set; }
    public double averagescore { get; set; }
}
