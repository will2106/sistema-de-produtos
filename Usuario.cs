using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDeProdutos
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Logado { get; set; }
        public static List<Usuario> ListaUsuarios { get; } = new List<Usuario>();


        public Usuario()
        {
            {
                ListaUsuarios.Add(this);
                Cadastrar();
            }

        }

        public void Cadastrar()
        {

            // this.Nome = "Lucas";
            // this.Email = "lrlacerda@gmail.com";
            // this.Senha = "1234";

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\nCadastre um Usuario para fazer o Login!\n");
            Console.ResetColor();
            
            Console.Write("Digite o código do usuário: ");
            Codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do usuário: ");
            Nome = Console.ReadLine();

            Console.Write("Digite o email do usuário:");
            Email = Console.ReadLine();

            Console.Write("Digite a senha do usuário: ");
            Senha = Console.ReadLine();

            this.DataCadastro = DateTime.Now;
            
        }

        public void Deletar(Usuario usuario)
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }

    }
}