using System;

namespace EstruturasCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Um diretor de uma empresa quer saber se os seus funcionarios estao gostando da empresa, porem caso alguem nao goste
            // ele quer saber o motivo. UM FUNCIONARIO

            string situacaoFuncionario;
            string respostaSeNao;

            Console.WriteLine("Você está satisfeito com o trabalho aqui? (Sim/Nao)");
            situacaoFuncionario = Console.ReadLine();

            if (situacaoFuncionario.ToLower() == "sim") // Para impedir conflito entre palavras maiuscula e minuscula, ele basicamente recebe tudo em minusculo.
            {
                Console.WriteLine ("Que legal, bom saber que você está satisfeito com a empresa!");
            }
            else if (situacaoFuncionario.ToLower() == "nao")
            {
                Console.WriteLine ("Por que você não está gostando de trabalhar em nossa empresa?");
                respostaSeNao = Console.ReadLine();
                Console.WriteLine ("A sua resposta é: " + respostaSeNao);
            }
            else
            {
                Console.WriteLine ("Opção inválida!");
            }
        Console.ReadKey();
        }
    }
}
