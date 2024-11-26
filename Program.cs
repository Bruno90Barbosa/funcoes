using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saque;
            Console.WriteLine("Qual o valor você deseja sacar? ");
            saque = int.Parse(Console.ReadLine());

            if(saque > 0 && saque <= 5000)
            {
                SaqueAprovado();
            }
            else if (saque >= 5001 && saque <= 9999)
            {
                EnviarDocumento();
            }
            else if (saque >= 10000)
            {
                ProcurarAgencia();
            }
            else if (saque == 0)
            {
                ValorZero();
            }
            else
            {
                Console.WriteLine("Obrigado por utilizar os nossos serviços.");
            }

            Console.ReadKey();

        }
        static void SaqueAprovado()
        {
            Console.WriteLine("Saque aprovado. O dinheiro será liberado.");
        }
        static void EnviarDocumento()
        {
            Console.WriteLine("Favor enviar uma foto da sua identidade ou CNH.");
        }
        static void ProcurarAgencia()
        {
            Console.WriteLine("Favor procurar a agência mais próxima da sua residência.");
        }
        static void ValorZero()
        {
            Console.WriteLine("Digite um avlor maior que R$ 1.");
        }

       
    }
}
