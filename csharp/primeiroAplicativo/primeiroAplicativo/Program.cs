using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiroAplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            string Condicao;
            Console.WriteLine("Hello Word"); //WriteLine escreve na linha de baixo, meio que uma quebra de linha imbutida no comando Write
            Console.WriteLine("Como estás?");
            Condicao = Console.ReadLine();

            Console.WriteLine("A sua condição é: " + Condicao); // + esta juntando uma string com outra string
            

            Console.ReadKey(); //Serve para parar o console, esperando que alguma tecla seja apertada para o programa encerrar
        }
    }
}
