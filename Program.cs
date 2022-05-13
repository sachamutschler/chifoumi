using System;

namespace shifumi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SHIFUMI");
            int scoreJoueur = 0;
            int scoreOrdi = 0;


            while (scoreJoueur < 3 && scoreOrdi < 3 )
            {
                
                int choixJoueur;
                Console.WriteLine("Entrez un signe : (1 pour Pierre, 2 pour Feuille, 3 pour ciseaux)");
                while (!int.TryParse(Console.ReadLine(), out choixJoueur) && (choixJoueur > 3 || choixJoueur < 1))
                {
                    Console.WriteLine("Erreur, Veuillez entrer un chiffre entre 1 et 3");
                }
                string inputJoueur = Convert(choixJoueur);           
                Console.WriteLine(inputJoueur);

                Random r = new Random();
                int choixOrdi = r.Next(1, 4);
                string inputOrdi = Convert(choixOrdi);
                Console.WriteLine(inputOrdi);
                int result = Compare(inputJoueur, inputOrdi);
                if (result == 1)
                {
                    scoreJoueur++;
                }

                else if (result == 3)
                {
                    scoreOrdi++;
                }

                Console.WriteLine("Score joueur : " + scoreJoueur);
                Console.WriteLine("Score Ordi : " + scoreOrdi);

            }
            if (scoreJoueur == 3)
            {
                Console.WriteLine("Vous avez gagné !");
            }
            else
            {
                Console.WriteLine("L'ordi a gagné !");
            }

        }

        /// <summary>
        /// Convertis la valeur en string pour le shifumi
        /// </summary>
        /// <param name="input">Nombre choisi par l'utilisateur</param>
        /// <returns>choix string</returns>
        static string Convert(int input)
        {
            switch (input)
            {
                case 1: 
                    return "pierre";

                case 2:
                    return "feuille";
                    

                case 3:
                    return "ciseaux";
    

                default: return null;
                    
            }
        }

        public static int Compare(string inputJoueur, string inputOrdi)
        {
            if (inputJoueur == "pierre")
            {
                if(inputOrdi == "pierre")
                {
                    Console.WriteLine("Egalité");
                }
                if(inputOrdi == "feuille")
                {
                    Console.WriteLine("Perdu");
                    return 3;
                }
                if(inputOrdi == "ciseaux")
                {
                    Console.WriteLine("Gagné");
                    return 1;
                }
            }
            if (inputJoueur == "feuille")
            {
                if (inputOrdi == "pierre")
                {
                    Console.WriteLine("Gagné");
                    return 1;
                }
                if (inputOrdi == "feuille")
                {
                    Console.WriteLine("Egalité");
                }
                if (inputOrdi == "ciseaux")
                {
                    Console.WriteLine("Perdu");
                    return 3;
                }
            }
            if (inputJoueur == "ciseaux")
            {
                if (inputOrdi == "pierre")
                {
                    Console.WriteLine("Perdu");
                    return 3;
                }
                if (inputOrdi == "feuille")
                {
                    Console.WriteLine("gagné");
                    return 1;
                }
                if (inputOrdi == "ciseaux")
                {
                    Console.WriteLine("Egalité");
                }
            }
            return 0;
        }
    }
}
