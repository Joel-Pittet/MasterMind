//nb couleur code, réponse utilisateur, couleur toute juste et couleur juste mais mauvais endroit
int NbColor = 0;
//string UserAnswer;
int GoodColorPlace = 0;
int GoodColor = 0;
int ColorUserCount = 1;
int TabCase = 0;
//int tries = 0;
var LColorUser = new List <string>();


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
var LColorSelected = new List<string>();


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

    LColorSelected.Add(ColorList[RandomColor]);
   

    NbColor++;

    Console.WriteLine($"{NbColor}. {ColorList[RandomColor]}");

} while (NbColor != 4);



Console.WriteLine("Quel est le code mystère selon vous ?");

//demande, récupère et insère dans un tableau les couleurs de l'utilisateur
for (int i = 0; i < 4; i++)
{

    Console.Write($"Couleur {ColorUserCount}: ");
    ColorUserCount++;
    LColorUser.Add(Console.ReadLine());


}


//compare les couleurs du code secret et de l'utilisateur 
for (int i = 0; i < LColorUser.Count; i++)
{

    if (LColorUser[i] == LColorSelected[i])
    {

        GoodColorPlace++;


    }

        
    LColorSelected.Remove(LColorSelected[i]);
    LColorUser.Remove(LColorUser[i]);

}



Console.WriteLine(LColorSelected[0]);
Console.WriteLine(LColorUser[0]);





Console.WriteLine($"Vous avez {GoodColorPlace} bonnes couleurs aux bons endroits");
Console.WriteLine($"Vous avez {GoodColor} couleurs juste en mauvaise position");






/*if (GoodColorPlace == 4)
{
    Console.WriteLine("Vous avez trouvé le code secret, Bravo !!");

}else if (tries == 10)
{
    Console.WriteLine("Vous avez atteint le nombre d'essais maximum, le code secret était");
}*/



























//Récupération de la réponse utilisateur
//UserAnswer = Console.ReadLine().ToLower();

//Si la réponse utilisateur est égale au code secret affiche un message de victoire
/*if (UserAnswer == $"{ColorSelected[0]},{ColorSelected[1]},{ColorSelected[2]},{ColorSelected[3]}")
{

    Console.WriteLine("Vous avez trouvé le code secret, Bravo !!");

}
else // Sinon compare chaque réponse de l'utilisateur pour voir s'il y en a des bonnes, lui affiche le nombre de juste
{
    var userColors = UserAnswer.Split(",");

    for (var i = 0; i < userColors.Length; i++)
    {

        if (userColors[i] == ColorSelected[i])
        {

            GoodColorPlace++;

            //Console.WriteLine(userColors[i]);
            ColorSelected.Remove(ColorSelected[i]);
            

        }

        
    }

   

    /*if (userColors[0] == ColorSelected[1] || userColors[0] == ColorSelected[2] || userColors[0] == ColorSelected[3])
    {

        GoodColor++;

    }
    else if (userColors[1] == ColorSelected[0] || userColors[1] == ColorSelected[2] || userColors[1] == ColorSelected[3])
    {
        GoodColor++;
    }
    else if (userColors[2] == ColorSelected[0] || userColors[2] == ColorSelected[1] || userColors[2] == ColorSelected[3])
    {
        GoodColor++;
    }
    else if (userColors[3] == ColorSelected[0] || userColors[3] == ColorSelected[1] || userColors[3] == ColorSelected[2])
    {
        GoodColor++;
    }

Console.WriteLine($"Vous avez {GoodColorPlace} bonnes couleurs aux bons endroits");
    Console.WriteLine($"Vous avez {GoodColor} couleurs juste en mauvaise position");

}
*/




