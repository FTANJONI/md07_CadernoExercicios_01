using System;

namespace md07_CadernoExercicios_01
{
    class Program
    {/*
      1. Escreva um programa com uma função que solicita a digitação do salário atual
        de um funcionário e o índice de reajuste. Exiba o salário reajustado.

      */
        public static double sal, indice;
       
        public static void CalcularNovoSalario(double newSal, double indic)
        {
            double nvSal = newSal * indic;
            Console.WriteLine("\nO novo salário do funcionário, corresponde ao montante: R$ {0}", nvSal.ToString("0.00"));
        }

        public static void SolicitaSalarioeIndice()
        {
            Console.WriteLine("Digite o Salário do Funcionário:");
            sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInforme o índice para cáluclo do novo salário:");
            indice = Convert.ToDouble(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            SolicitaSalarioeIndice();
            CalcularNovoSalario(sal, indice);
            Console.WriteLine("\nFim!");

        }
    }
}
