Console.WriteLine("+----------+");
Console.WriteLine("|MasterMind|");
Console.WriteLine("+----------+");

int NbColor = 0;
string RandomColorName;
string UserAnswer;

var ColorList = new List<string>();
ColorList.Add("White");
ColorList.Add("Red");
ColorList.Add("Green");
ColorList.Add("Blue");
ColorList.Add("Yellow");
ColorList.Add("Cyan");
ColorList.Add("Magenta");
ColorList.Add("Gray");


do
{
    Random RandomCode = new Random();
    int RandomColor = RandomCode.Next(ColorList.Count);
    NbColor++;

    Console.WriteLine(ColorList[RandomColor]);

} while (NbColor != 5);




Console.WriteLine("Quel est le code mystère selon vous ?");
UserAnswer = Console.ReadLine();
