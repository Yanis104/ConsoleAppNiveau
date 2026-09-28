using System;

namespace ConsoleAppNiveau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal NiveauBase;
            int Quetes;
            char Classe;

            Console.Write("Quel est votre niveau ? : ");
            NiveauBase = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Choisissez votre classe principale :");
            Console.WriteLine("G - Guerrier");
            Console.WriteLine("M - Mage");
            Console.WriteLine("R - Rogue");

            Classe = char.Parse(Console.ReadLine());

            Console.Write("Combien de quêtes héroïques  ? : ");
            Quetes = int.Parse(Console.ReadLine());

            switch (Classe)
            {
                case 'G':
                    if (NiveauBase < 10)
                        Console.WriteLine("Novice");
                    else if (NiveauBase <= 20 && Quetes >= 5)
                        Console.WriteLine("Adepte");
                    else if (NiveauBase <= 20)
                        Console.WriteLine("Apprenti assermenté");
                    else if (NiveauBase < 30)
                        Console.WriteLine("Vétéran");
                    else if (Quetes > 20)
                        Console.WriteLine("Maître de Guilde");
                    else
                        Console.WriteLine("Statut Indéterminé / Hors-la-loi");
                    break;

                case 'M':
                    if (NiveauBase < 10)
                        Console.WriteLine("Novice");
                    else if (NiveauBase <= 20 && Quetes >= 5)
                        Console.WriteLine("Adepte");
                    else if (NiveauBase <= 20)
                        Console.WriteLine("Apprenti assermenté");
                    else if (NiveauBase >= 25)
                        Console.WriteLine("Vétéran");
                    else
                        Console.WriteLine("Statut Indéterminé / Hors-la-loi");
                    break;

                case 'R':
                    if (NiveauBase < 10)
                        Console.WriteLine("Novice");
                    else if (NiveauBase <= 20 && Quetes >= 5)
                        Console.WriteLine("Adepte");
                    else if (NiveauBase <= 20)
                        Console.WriteLine("Apprenti assermenté");
                    else if (NiveauBase < 30)
                        Console.WriteLine("Vétéran");
                    else
                        Console.WriteLine("Statut Indéterminé / Hors-la-loi");
                    break;

               
            }
        }
    }
}