using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDeProdutos
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        public static List<Marca> ListaDeMarcas { get; } = new List<Marca>();

        public Marca Cadastrar()
        {
            Marca novaMarca = new Marca();

            Console.Write("Digite o código da marca: ");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da marca: ");
            novaMarca.NomeMarca = Console.ReadLine();

            novaMarca.DataCadastro = DateTime.Now;

            ListaDeMarcas.Add(novaMarca);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nMarca cadastrada com sucesso!");
            Console.ResetColor();
            

            return novaMarca;
        }

        public void Listar()
        {
            Console.WriteLine("\n=== LISTA DE MARCAS ===\n");
            foreach (var marca in ListaDeMarcas)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Código: {marca.Codigo}");
                Console.WriteLine($"Nome: {marca.NomeMarca}");
                Console.WriteLine($"Data de Cadastro: {marca.DataCadastro}");
                Console.WriteLine("=======================");
                Console.ResetColor();
            }
        }

        public void Deletar(int codigo)
        {
            Marca marca = ListaDeMarcas.FirstOrDefault(m => m.Codigo == codigo);

            if (marca != null)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                ListaDeMarcas.Remove(marca);
                Console.WriteLine("\nMarca removida com sucesso!");
            }
            else
            {
                Console.WriteLine("\nMarca não encontrada!");
                Console.ResetColor();
            }
        }
    }
}

























