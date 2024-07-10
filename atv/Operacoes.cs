using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv
{
    public class Operacoes
    {
        int num1 { get; set; }
        int num2 { get; set; }
        int resultado { get; set; }
        int escolha { get; set; }

        public void MenuOpe()
        {
            Console.WriteLine("Escreva o primeiro numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma operação");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            escolha = int.Parse(Console.ReadLine());


            if (escolha == 1)
            {
                resultado = num1 + num2;
                Console.WriteLine("Resultado: " + resultado);
            }else if(escolha == 2)
            {
                resultado = num1 - num2;
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (escolha == 3)
            {
                resultado = num1 * num2;
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (escolha == 4)
            {
                resultado = num1 / num2;
                Console.WriteLine("Resultado: " + resultado);
            }
        }
    }
}
