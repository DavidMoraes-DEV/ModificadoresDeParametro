﻿using System;

namespace ModificadorParams
{
    class Program
    {
        static void Main(string[] args) {


        int s1 = Calculadora.Soma(new int[] { 20, 30 }); //Utilizando um vetor para enviar os valores desejados

        int s2 = Calculadora.Soma(2, 3 ); //A palavra PARAMS aplicada a função SOMA possibilita que
                                              //não seja necessario instânciar um vetor na sua chamada podendo
                                              //inserir diretamente os parâmetros de entrada necessarios para
                                              //enviar para a função.

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
