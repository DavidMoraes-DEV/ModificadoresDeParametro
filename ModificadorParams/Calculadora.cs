using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadorParams
{
    class Calculadora
    {
        //O params tem como objetivo avisar para a função que queremos parâmetro VARIÁVEIS, ou seja, diferentes tipos de quantidade de parâmetros de entrada
        public static int Soma (params int[] numbers) //Função de Soma utilizando um Vetor como Parâmetro para a soma.
        {
            int soma = 0;
            for(int i=0; i<numbers.Length; i++) // A Palavra "Length" tem a função de puxar o tamanho do vetor automaticamente
            {
                soma += numbers[i];
            }
            return soma;
        }
    }
}
