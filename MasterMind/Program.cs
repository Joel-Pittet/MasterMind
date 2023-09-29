///ETML
///Auteur: Joël Pittet
///Date: 29.09.2023
///Description: Réplique informatique du jeu mastermind
///

//nb couleur code, réponse utilisateur, couleur toute juste et couleur juste mais mauvais endroit
int NbColor = 0;
int GoodColorPlace = 0;
int GoodColor = 0;
int ColorUserCount = 1;
int tries = 1;
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


do
{
    Console.WriteLine("Quel est le code mystère selon vous ?");

    //Réinitialise le compteur pour qu'il y ai toujours la suite 1. 2. 3. 4. quand l'utilisateur rentre les couleurs
    ColorUserCount = 1;

    Console.WriteLine($"Essai numéro {tries}");

    //demande, récupère et insère dans un tableau les couleurs de l'utilisateur
    for (int i = 0; i < 4; i++)
    {
        
        Console.Write($"Couleur {ColorUserCount}: ");
        ColorUserCount++;
        LColorUser.Add(Console.ReadLine().ToLower());


    }

    tries++;
    //Copie de la liste du code secret pour pouvoir retirer les couleurs juste sans problème
    //et pouvoir gérer les couleurs juste au mauvais endroit
    //var LColorSelectedCopy = new List<string>(LColorSelected);

    //compare les couleurs du code secret et de l'utilisateur 
    for (int i = 0; i < LColorUser.Count; i++)
    {
        //Ajoute 1 à chaque couleur donnée qui correspond au code secret 
        if (LColorUser[i] == LColorSelected[i])
        {

            GoodColorPlace++;
            //Check dans la liste du code si elle contient des couleurs données
        }
        else if (LColorSelected.Contains(LColorUser[i]))
        {
            //enlève les couleurs trouvées pour compter les couleurs
            //justes au mauvais endroits 
            LColorSelected.Remove(LColorUser[i]);
            GoodColor++;

        }

    }




    //Retourne à l'utilisateur le nombre de bonne couleurs et le nombre de couleurs juste au mauvais endroit
   Console.WriteLine($"Vous avez {GoodColorPlace} bonnes couleurs aux bons endroits");
   Console.WriteLine($"Vous avez {GoodColor} couleurs juste en mauvaise position");


}while (tries <= 10);




/*if (GoodColorPlace == 4)
{
    Console.WriteLine("Vous avez trouvé le code secret, Bravo !!");

}else if (tries == 10)
{
    Console.WriteLine("Vous avez atteint le nombre d'essais maximum, le code secret était");
}*/
