//
int NbColor = 0;
string UserAnswer;
int GoodColor = 0;

//Liste pour couleurs disponibles
var ColorList = new List<string>();
ColorList.Add("rouge");
ColorList.Add("vert");
ColorList.Add("bleu");
ColorList.Add("orange");
ColorList.Add("jaune");
ColorList.Add("violet");
ColorList.Add("rose");

//Liste pour code secret
var ColorSelected = new List<string>();


Console.WriteLine("+----------+");
Console.WriteLine("|MasterMind|");
Console.WriteLine("+----------+");

Console.WriteLine("Bienvenue dans le MasterMind");
Console.WriteLine("Les couleurs disponibles sont les suivantes: rouge, vert, bleu, orange, jaune, violet, rose");

//Boucle pour la création du code grâce à ColorList
do
{
    Random RandomCode = new Random();
    int RandomColor = RandomCode.Next(ColorList.Count);

    ColorSelected.Add(ColorList[RandomColor]);

    NbColor++;

    Console.WriteLine($"{NbColor}. {ColorList[RandomColor]}");

} while (NbColor != 4);



Console.WriteLine("Quel est le code mystère selon vous ?");
Console.WriteLine("Réponse sous ce format: vert,jaune,vert,jaune");

//Récupération de la réponse utilisateur
UserAnswer = Console.ReadLine().ToLower();


//Si la réponse utilisateur est égale au code secret affiche un message de victoire
if (UserAnswer == $"{ColorSelected[0]},{ColorSelected[1]},{ColorSelected[2]},{ColorSelected[3]}")
{

    Console.WriteLine("Vous avez trouvé le code secret, Bravo !!");

}
else // Sinon compare chaque réponse pour voir s'il y en a des bonnes, lui affiche le nombre de juste
{
    var userColors = UserAnswer.Split(",");

    for (var i = 0; i < userColors.Length; i++)
    {

        if (userColors[i] == ColorSelected[i])
        {

            GoodColor++;

        }


        //Console.WriteLine($"{userColors[i]} --  {ColorSelected[i]}");
    }

    Console.WriteLine($"Vous avez {GoodColor} bonnes couleurs aux bons endroits");




}





