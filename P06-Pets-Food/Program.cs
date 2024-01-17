int countPackagesDogFood  = int.Parse(Console.ReadLine());
int countPackagesCatFood = int.Parse(Console.ReadLine());

double calculatedExpenses = countPackagesDogFood * 2.50 + countPackagesCatFood * 4.00;

Console.WriteLine($"{calculatedExpenses:F2} lv.");