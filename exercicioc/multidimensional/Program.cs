﻿// See https://aka.ms/new-console-template for more information

class Program {
    public static void Main(){
        string[,,] semestre;
        semestre = new string[2,3,2] 
        {
            {
                {"Janeiro", "Fevereiro"},
                {"Março", "Abril"},
                {"Maio", "Junho"}
            },
            {
                {"Julho", "Agosto"},
                {"Setembro", "Outubro"},
                {"Novembro", "Dezembro"}
            }
        };

        

      //  foreach (string s in semestre) {
      //      Console.WriteLine(s);
      //  }

        for (int i = 0; i < semestre.GetLength(1); i++) {
            for (int j = 0; j < semestre.GetLength(2); j++) {
                
                Console.WriteLine(semestre[0,i,j]);
            }
        }
    }                
}