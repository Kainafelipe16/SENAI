﻿// See https://aka.ms/new-console-template for more information
class Program {

    public static void Main(){
        Console.WriteLine("Digite a média");
        float media = float.Parse(Console.ReadLine());

        if (media >= 7){
            Console.WriteLine("Aprovado! Very Nice!");
        }
        else{
            Console.WriteLine("Reprovado seu animalista!!");
        }
    }
}
