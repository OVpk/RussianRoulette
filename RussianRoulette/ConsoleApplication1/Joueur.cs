﻿using System;
using System.ComponentModel.Design.Serialization;
using System.Data.SqlTypes;

namespace ConsoleApplication1
{
    public class Joueur
    {
        public string pseudoJoueur1;
        public string pseudoJoueur2;
        public bool j1Prio;
        public bool j2Prio;
        
        public void Role()
        {
            Console.WriteLine("entrée nom du J1 : ");
            pseudoJoueur1 = Console.ReadLine();
            
            Console.WriteLine("entrée nom du J2 : ");
            pseudoJoueur2 = Console.ReadLine();

            Random rnd = new Random();
            
            
            if (rnd.Next(2) == 0)
            {
                Console.WriteLine(pseudoJoueur1+" commence la partie");
                j1Prio = true;
                j2Prio = false;
            }
            else 
            {
                Console.WriteLine(pseudoJoueur2+" commence la partie");
                j1Prio = false;
                j2Prio = true;
            }
            
                
                
        }
            
    }
        
        
    
}