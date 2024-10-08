using System;
using Microsoft.SqlServer.Server;

namespace ConsoleApplication1
{
    public class Tableau
    {

        public string[,] InitialisationTableau()
        {

            string[,] tableau2D = new string[4, 7];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i==0 && j == 3 || i ==1 && j==1 || i ==1 && j==5|| i ==2 && j==1 || i ==2 && j==5 || i==3 && j == 3)
                    {
                     tableau2D[i, j] = "O";
                    }
                    else
                    {
                        tableau2D[i, j] = "■";
                    }
                    Console.Write(tableau2D[i, j]);
                    if (j==6)
                    {
                        Console.WriteLine();
                    }
                
                }
            }
            return tableau2D;



        }

       
        
    }
}