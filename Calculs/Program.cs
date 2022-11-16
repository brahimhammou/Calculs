﻿/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse = 0;//saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur
            bool correct = false; //boollen pour savoir si choix est un int
            bool correct1 = false; // boolv2
            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                while (!correct)
                {
                    try
                    {
                        choix = int.Parse(Console.ReadLine());
                        if (choix == 1 | choix == 2 | choix == 0)
                        {
                            correct = true;
                        }
                        else
                        {
                            Console.WriteLine("Erreur de saisie. Veuillez choisir entre 1; 2 et 0");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie. Veuillez choisir entre 1; 2 et 0");
                    }
                }
                correct = false;
                correct1 = false;
                // traitement des choix
                if (choix != 0)
                {
                    if (choix == 1)
                    {
                        // choix de l'addition
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);                       
                        while (!correct1)
                        {
                            // saisie de la réponse
                            Console.Write(val1 + " x " + val2 + " = ");
                            try
                            {
                                reponse = int.Parse(Console.ReadLine());
                                correct1 = true;
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de saisie. Veuillez entrer un nombre entier");
                            }
                        }
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                    }
                    else
                    {
                        // choix de la multiplication
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);                                               
                       while (!correct1)
                        {
                            // saisie de la réponse
                            Console.Write(val1 + " x " + val2 + " = ");
                            try
                            {
                                reponse = int.Parse(Console.ReadLine());
                                correct1 = true;
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de saisie. Veuillez entrer un nombre entier");
                            }
                        }
                        // comparaison avec la bonne réponse
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }
                    }
                }
            }
        }
    }
}
