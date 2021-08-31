using System;

namespace terceiroAplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uma escola te contratou para desenvolver um aplicativo que realize a média das notas dos alunos de uma sala,
            // lembrando que atualmente a sala tem apenas 5 alunos e a nota vai de 0 a 10

            Console.WriteLine("Média de alunos");

             float soma = 0;
             float media = 0;

             for (int i = 0; i < 5; i++)
             { 
                Console.WriteLine("Digite a nota do aluno " + i + ": ");
                float nota = 0;
                float.TryParse(Console.ReadLine(), out nota); // vai receber oq for digitado e converter para float e depois vai devolver para a variavel nota
                soma = soma + nota; //ou soma += nota;
             }

             media = soma / 5;
             Console.WriteLine("Média é igual a: " + media);
             Console.ReadKey();
        }
    }
}
