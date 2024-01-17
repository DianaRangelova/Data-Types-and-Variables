string architectsName = Console.ReadLine();
int countOfProjects = int.Parse(Console.ReadLine());

double calculateHours = countOfProjects * 3;

Console.WriteLine($"The architect {architectsName} will need {calculateHours} hours to complete {countOfProjects} project/s.");