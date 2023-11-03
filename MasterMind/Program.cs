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
var userGuess = new List <string>();
string finalAnswer;


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
var secretCode = new List<string>();


Console.WriteLine("+--------------+");
Console.WriteLine("|  MasterMind  |");
Console.WriteLine("+--------------+");

Console.WriteLine("Bienvenue dans le MasterMind\n\n");
Console.WriteLine("Les couleurs disponibles sont les suivantes: rouge, vert, bleu, orange, jaune, violet, rose\n");

do
{
    //Réinitialisation des variables
    tries = 1;
    NbColor = 0;
    userGuess = new List<string>();
    secretCode = new List<string>();
   


    //Boucle pour la création du code grâce à ColorList
    do
    {
        Random RandomCode = new Random();
        int RandomColor = RandomCode.Next(ColorList.Count);

        secretCode.Add(ColorList[RandomColor]);

        NbColor++;

    } while (NbColor != 4);


    do
    {
        Console.WriteLine("\nQuel est le code mystère selon vous ?\n");

        //Réinitialise le compteur pour qu'il y ai toujours la suite 1. 2. 3. 4. quand l'utilisateur rentre les couleurs
        ColorUserCount = 1;
        GoodColorPlace = 0;
        GoodColor = 0;

        //Réinitialise la list pour que l'index n'aille pas au dessus de 4
        userGuess = new List<string>();
        Console.WriteLine($"Essai numéro {tries}\n");

        //Demande, récupère et insère dans un tableau les couleurs de l'utilisateur
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Couleur {ColorUserCount}: ");
            ColorUserCount++;
            userGuess.Add(Console.ReadLine().ToLower());


        }

        tries++;

        //Copie de les listes de couleurs de l'utilisateur et du code secret pour pouvoir retirer
        //les couleurs juste et au bon endroit sans problème d'index
        //et pouvoir gérer les couleurs juste au mauvais endroit
        var secretCodeCopy = secretCode.ToList();
        var userGuessCopy = userGuess.ToList();

        //compare les couleurs du code secret et de l'utilisateur 

        for (int i = 0; i < userGuess.Count; i++)
        {
            //Compte le nombre de couleur juste au bon endroit, en comparant le code et l'essai de l'utilisateur
            if (userGuess[i] == secretCode[i])
            {

                GoodColorPlace++;

                //Enlève les couleurs juste au bon endroit trouvées
                secretCodeCopy.Remove(userGuess[i]);
                userGuessCopy.Remove(userGuess[i]);

            }

        }

        //Vérifie dans la liste du code si elle contient des couleurs données
        for (int i = 0; i < userGuessCopy.Count; i++)
        {
            if (secretCodeCopy.Contains(userGuessCopy[i]))
            {
                GoodColor++;
            }
        }

 
    

        //Retourne à l'utilisateur le nombre de bonne couleurs et le nombre de couleurs juste au mauvais endroit
        Console.WriteLine($"\nVous avez {GoodColorPlace} bonnes couleurs aux bons endroits\n");
       Console.WriteLine($"Vous avez {GoodColor} couleurs juste en mauvaise position\n");


    }while (GoodColorPlace != 4 && tries <= 10);


    //Message de victoire et de défaite
    if (GoodColorPlace == 4)
    {
        Console.WriteLine("Vous avez trouvé le code secret, Bravo !!");

    }else if (tries > 10)
    {
        Console.WriteLine($"Vous avez atteint le nombre d'essais maximum, le code secret était: {secretCode[0]} {secretCode[1]} {secretCode[2]} {secretCode[3]}");
    }

    Console.WriteLine("Voulez-vous rejouer ? [o/n]");
    finalAnswer = Console.ReadLine();

}while (finalAnswer != "n");