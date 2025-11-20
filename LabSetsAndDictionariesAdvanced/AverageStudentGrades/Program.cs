namespace AverageStudentGrades;

class Program
{
    static void Main(string[] args)
    {
        int studentsCount = int.Parse(Console.ReadLine());

        var students = new Dictionary<string, List<decimal>>();

        for (int i = 0; i < studentsCount; i++)
        {
            var command = Console.ReadLine().Split();
            var name = command[0];
            var grade = decimal.Parse(command[1]);

            if (!students.ContainsKey(name))
            {
                students[name] = new List<decimal>();
            }

            students[name].Add(grade);
        }

        foreach (var student in students)
        {
            var name = student.Key;
            var grades = student.Value;

            Console.Write($"{name} -> ");

            foreach (var grade in grades)
            {
                Console.Write(grade + " ");
            }

            var averageGrade = grades.Average();
            Console.WriteLine($"(avg: {averageGrade:f2})");
        }
    }
}