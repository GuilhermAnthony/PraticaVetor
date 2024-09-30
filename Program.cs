using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            Paciente cliente = new Paciente();

            while (opcao.ToLower() != "q")
            {
                Console.Clear();
                Console.WriteLine("1. Cadastrar paciente");
                Console.WriteLine("2. Cadastrar paciente prioritário");
                Console.WriteLine("3. Ver fila de espera");
                Console.WriteLine("4. Atender paciente");

                Console.WriteLine("Tecle 'q' para sair.");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        cliente.cadastrarPaciente();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        cliente.cadastrarPrioritario();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        cliente.listarPaciente();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        cliente.atenderPaciente();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida");
                        break;
                }
            }
        
        }
    }
}
