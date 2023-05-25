using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoDeProdutos
{
    public class Login
    {
        public bool Logado { get; set; }
        private Usuario usuario { get; set; }

        public Login()
        {
            this.usuario = new Usuario();

            Logar(usuario);

            if (Logado == true)
            {
                GerarMenu();
            }
        }

        public void Logar(Usuario usuario)
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"\nFazer Login!\n");
                Console.ResetColor();

                Console.Write($"\nInsira seu email: ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                string email = Console.ReadLine();
                Console.ResetColor();

                Console.Write($"Insira sua senha: ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                string senha = Console.ReadLine();
                Console.ResetColor();

                if (email == usuario.Email && senha == usuario.Senha)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    this.Logado = true;
                    Console.WriteLine($"\nLogin efetuado com sucesso !");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    this.Logado = false;
                    Console.WriteLine(@$"
                    Falha ao logar! 
                    Usuario ou senha inválidos...
                    ");
                    Console.ResetColor();
                }


            } while (Logado == false);
        }

        public void Deslogar()
        {
            Logado = false;
        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();


            string opcao;

            do
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Bem vindo ao sistema de cadastro de produto!!");
                Console.WriteLine($"Escolha uma das opsões para continuar...");


                Console.WriteLine(@$"
            1 - Cadastrar Produto
            2 - Listar Produtos
            3 - Remover Produto
            ----------------------
            4 - Cadastrar Marca
            5 - Listar Marcas
            6 - Remover Marca
            ----------------------
            7 - Cadastrar Usuário
            8 - Deletar Usuários
            ----------------------
            0 - Sair
            ");
                Console.ResetColor();

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        produto.Cadastrar();
                        break;
                    case "2":

                        produto.Listar();
                        break;
                    case "3":

                        Console.WriteLine($"Informe o código a ser removido: ");
                        int codigoProduto = int.Parse(Console.ReadLine());

                        produto.Deletar(codigoProduto);
                        break;
                    case "4":

                        marca.Cadastrar();
                        break;
                    case "5":

                        marca.Listar();
                        break;
                    case "6":

                        Console.Write($"Informe o código a ser removido: ");
                        int codigoMarca = int.Parse(Console.ReadLine());

                        marca.Deletar(codigoMarca);
                        break;

                    case "7":
                        usuario.Cadastrar();
                        break;

                    case "8":
                        usuario.Deletar(usuario);
                        break;

                    case "0":

                        Console.WriteLine($"Programa encerrado !");
                        break;
                    default:
                        Console.WriteLine($"Opção inválida!");
                        break;
                }

                Console.WriteLine("Carregando...");
                MostrarBarraDeCarregamento();

                Thread.Sleep(1000); // Pausa de 1 segundo para criar o efeito de animação

                Task.Delay(1000).Wait(); // Pausa de 1 segundos antes de limpar a tela
                Console.Clear();

            } while (opcao != "0");

        }

        private void MostrarBarraDeCarregamento()
        {
            Console.Write("[");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("█");
                Thread.Sleep(100);
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
