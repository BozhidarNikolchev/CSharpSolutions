// Where - is used to check a given condition. It is part of LINQ.

//double a = 0.1;
//double b = 0.1;
//bool check = false;

//double eps = 0.000001;
//if (Math.Abs(a - b)  < eps)
//{
//    check = true;
//}

//Console.WriteLine(check);

int a = int.Parse(Console.ReadLine());

int[] array = a.ToString().Where(char.IsDigit).Select(d => d - '0').ToArray();

foreach (int number in array)
{
    Console.WriteLine(number);
}