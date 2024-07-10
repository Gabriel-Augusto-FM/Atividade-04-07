using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv
{
    public class Verificar
    {
        int num1 { get; set; }
        int num2 { get; set; }
        int opcao { get; set; }
        int resultado { get; set; }

        public void verificar()
        {
            Console.WriteLine("Escreva o primeiro numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo numero");
            num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Escolha uma opção");
            opcao= int.Parse(Console.ReadLine());

            Console.WriteLine("1 - Verificar se são múltiplos");
            Console.WriteLine("2 - Verificar se são pares");
            Console.WriteLine("3 - Verificar se média é maior ou igual a 7");
            Console.WriteLine("4 - Sair");


            if(opcao==1)
            {
                if(num1 > num2)
                {
                    resultado = num1 % num2;
                    Console.WriteLine("São multiplos um do outro");
                }
                else if(num1 < num2)
                {
                    resultado = num2 % num1;
                    Console.WriteLine("São multiplos um do outro");
                }
                else
                {
                    Console.WriteLine("Não são multiplos");
                }
            }
            else if (opcao == 2)
            {
                if(num1%2==0 || num2%2==0)
                {
                    Console.WriteLine("os números são pares");
                }else if (num1 % 2 != 0 || num2 % 2 != 0)
                {
                    Console.WriteLine("os números não são pares");
                }else if (num1 % 2 == 0 || num2 % 2 != 0)
                {
                    Console.WriteLine("apenas o primeiro numero é par");
                }else if (num1 % 2 != 0 || num2 % 2 == 0)
                {
                    Console.WriteLine("apenas o segundo numero é par");
                }
            }
            else if(opcao == 3)
            {
                resultado = (num1 + num2)/2;
                if (resultado > 7)
                {
                    Console.WriteLine("média é maior que 7");
                }else if(resultado == 7)
                {
                    Console.WriteLine("média é igual à 7");
                }else if(resultado < 7)
                {
                    Console.WriteLine("média é menor à 7");
                }
            }
        }
    }
}
