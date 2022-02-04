using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_2_ti
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, RA;
            double np1, np2, pim;
            double media = 0;
            int i;
            double soma = 0;
            double media_sala;
            int Qt;

            Console.WriteLine("Quantos Alunos?: ");
            Qt = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            //          inicio;parada;incremento

            for (i = 0; i < Qt; i++)
            {
                // i++  igual a (i = i + 1)

                Console.WriteLine("Aluno" + (i + 1) + ":"); //  usa (i+1) para efetuar a soma em () primeiro

                Console.WriteLine("Nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("RA: ");
                RA = Console.ReadLine();

                for (np1 = 11; np1 < 0 || np1 > 10;) // sempre ter os (; ; )
                {
                    Console.WriteLine("NP1: ");
                    np1 = Convert.ToDouble(Console.ReadLine());
                    if (np1 < 0 || np1 > 10)
                    {
                        Console.WriteLine("Nota errada!!!(de 0 ate 10)!!!");
                    }
                }

                for (np2 = 11; np2 < 0 || np2 > 10;)
                {
                    Console.WriteLine("NP2: ");
                    np2 = Convert.ToDouble(Console.ReadLine());
                    if (np2 < 0 || np2 > 10)
                    {
                        Console.WriteLine("Nota errada !!!(de 0 ate 10!!!");
                    }
                }

                for (pim = 11; pim < 0 || pim > 10;)
                {
                    Console.WriteLine("PIM: ");
                    pim = Convert.ToDouble(Console.ReadLine());
                    if (pim < 0 || pim > 10)
                    {
                        Console.WriteLine("Nota errada !!!(de 0 ate 10)!!!");
                    }
                }

                media = np1 * 0.4 + np2 * 0.4 + pim * 0.2;
                Console.WriteLine("Média: " + media);

                soma = soma + media;

                // if aprovado reprovado
                if (media >= 5)
                {
                    Console.WriteLine("APROVADO");

                }
                else
                {
                    Console.WriteLine("REPROVADO");
                }

                Console.ReadKey();
                Console.Clear();
            }
            media_sala = soma / Qt;
            Console.WriteLine("Media Sala: " + media_sala);
            Console.ReadKey();

        }
    }
}