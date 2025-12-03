string architectsName = Console.ReadLine();
int countOfProjects = int.Parse(Console.ReadLine());

int hours = countOfProjects * 3;

Console.WriteLine($"The architect {architectsName} will need {hours} hours to complete {countOfProjects} project/s.");