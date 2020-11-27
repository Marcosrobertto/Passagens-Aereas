using System;

namespace Passagens
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declarações de Variáveis
            bool senhaValida;
            int escolha;
            int contador =0;
            string resposta;
            // Dados da passagem
            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];



            Console.Clear();
            Console.WriteLine("---Sistema de passagens---");
            Console.WriteLine();

            // Login
            do
            {
                Console.WriteLine("Digite a senha para acessar o sistema");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);
            } while (!senhaValida);
            
            // menu
            
            do
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("Seleciona uma opção a baixo");
                Console.WriteLine("[1] - Cadastrar Passagem");
                Console.WriteLine("[2] - Listar Passagens");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Cadastro de passageiro");
                        do
                        {
                            if(contador < 5){
                            Console.WriteLine($"Digite o nome do {contador+1}° passageiro:");
                            nomes[contador] = Console.ReadLine();
                            Console.WriteLine("Digite o destino:");
                            destino[contador] = Console.ReadLine();
                            Console.WriteLine("Digite o origem:");
                            origem[contador] = Console.ReadLine();
                            Console.WriteLine("Digite a data do vôo:");
                            data[contador] = Console.ReadLine();
                            
                            contador++;
                            }else{
                                Console.WriteLine("Você chegou no limite");
                                break;
                            }
                            Console.WriteLine("Você gostaria de cadastrar um novo passageiro? s/n");
                            resposta = Console.ReadLine();

                        } while (resposta.ToUpper() == "S");
                        Console.Clear();
                        break;
                        
                    case 2:
                        Console.WriteLine("Listar passagens");
                        for (var i = 0; i < contador; i++){
                            Console.WriteLine($"Passageiro {nomes[i]}, Destino {destino[i]}, data do vôo: {data[i]}.");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por viajar conosco ");
                        break;    
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }

            } while (true);



            // Funcões
           bool EfetuarLogin (string senha){
                if (senha == "123456"){
                    Console.WriteLine("Senha válida");
                    return true;
                    
                }else{
                    Console.WriteLine("Senha inválida, tente novamente");
                    return false;
                }
            }


        }
    }
}
