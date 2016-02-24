using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_de_Criptografia
{
    class Program
    {
        static void Main(string[] args)
        {


            //declaração de variáveis
            
            string p, encrypt;
            int  i, opcao, crypt, codigo;
            bool b1;

            //do..while para repetição do programa até que seja escolhida a opção sair
            do
            {
                //menu do programa
                Console.WriteLine("CRIPTOGRAFIA - CIFRA DE CESAR\n");

                Console.WriteLine("1 para Criptografar");
                Console.WriteLine("2 para Descriptografar");
                Console.WriteLine("0 para Sair\n");

                Console.Write("Digite a opção: ");

                //do..while para repetição até que o usuário digite uma opção válida
                do
                {
                    encrypt = "";
                    p = "";

                    //usando uma variável boleana para verificar se o que o usuário digitar é um valor do tipo inteiro
                    b1 = int.TryParse(Console.ReadLine(), out opcao);


                    //se a opção for falsa, mostrar a mensagem abaixo
                    if (((opcao != 1) && (opcao != 0) && (opcao != 2)) || (b1 == false))
                    {
                        Console.Write("Opção inválida, por favor digite novamente: ");
                    }


                }
                while (((opcao != 1) && (opcao != 0) && (opcao != 2)) || (b1 == false));


                //usando o comando switch..case para a escolha da opção
                switch (opcao)
                {


                    //caso a opção digitada seja '1'..
                    case 1: Console.Write("\nEntre com a mensagem para ser criptografada: ");

                        //do..while para consistir até que o usuário digite algo
                        do
                        {
                            //recebe o valor digitado pelo usuário, atribui à variável 'p' e em letra minúscula com o comando .ToLower()
                            p = Console.ReadLine().ToLower();

                            //se não for digitado nada, mostre a mensagem abaixo
                            if (p == "")
                            {
                                Console.Write("Por favor, não deixe este campo em branco. Digite novamente: ");
                            }

                                
                            //se nao(se for digitado algo) então faça..
                            else
                            {
                                //estrutura de repetição 'for', para criptografar letra por letra digitadas pelo usuário
                                for (i = 0; i < p.Length; i++)
                                {
                                    //a variável crypt recebe a primeira letra digitada pelo usuário, e com o laço de repetição ela recebe as outras em seguida, até a ultima
                                    crypt = p[i];
                                    //para a letra digitada, é acrescentado 3 na tabela ASCII
                                    codigo = crypt + 3;
                                    /*atribui a variável encrypt a letra que foi criptografada, sendo assim, depois de todas as
                                     letras da palavra digitada pelo usuário serem criptografadas e adicionadas à variável, 
                                     formará um código da palavra digitada, que será o conteúdo da variável encrypt*/
                                    encrypt += Convert.ToChar(codigo);
                                }
                                //mostra o resultado da criptografia
                                Console.Write("\nMensagem criptografada: " + encrypt);

                                Console.Write("\n\n\n-------TECLE ENTER PARA CRIPTOGRAFAR OU DESCRIPTOGRAFAR OUTRA MENSAGEM.-------\n\n");

                                Console.ReadKey();
                            }

                        }
                        while (p == "");

                        break;




                    /*lcaso a opção digitada seja '2', acontecerá o mesmo processo que no primeiro caso, porém na hora da criptografia
                        ao invés de ser acrescentado 3 casas na tabela ASCII será decrementado, fazendo o processo de descriptografia*/
                    case 2: Console.Write("\nEntre com a mensagem para ser descriptografada: ");

                        do
                        {
                            p = Console.ReadLine().ToLower();

                            if (p == "")
                            {
                                Console.Write("Por favor, não deixe este campo em branco. Digite novamente: ");
                            }



                            else
                            {
                                for (i = 0; i < p.Length; i++)
                                {
                                    crypt = p[i];
                                    codigo = crypt - 3;
                                    encrypt += Convert.ToChar(codigo);
                                }

                                Console.Write("\nMensagem descriptografada: " + encrypt);

                                Console.Write("\n\n\n-------TECLE PARA VOLTAR AO MENU.-------\n\n\n");

                               
                              


                                
                            }

                        }
                        while (p == "");

                        break;


                }
            }

            while (opcao != 0); 
        }
    }
}
