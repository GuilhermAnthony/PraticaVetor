using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaVetor
{
    internal class Paciente
    {
        public Paciente[] pasc;
        public string nome;
        public string cpf;
        public int idade;
        public bool prioridade;
        public int quantidadeFila = 0;
        public int prioridades = 0;


        public Paciente(string nome = "", string cpf = "", int idade = 0, bool prioridade = false)
        {
            pasc = new Paciente[11];
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.prioridade = prioridade;
        }

        public void cadastrarPaciente()
        {
            if (quantidadeFila < 11)
            {
            Console.WriteLine("Nome do paciente:");
            nome = Console.ReadLine();
    
            Console.WriteLine("CPF do paciente:");
            cpf = Console.ReadLine();
    
            Console.WriteLine("Idade do paciente:");
            idade = int.Parse(Console.ReadLine());
    
            Paciente paciente = new Paciente(nome, cpf, idade);
    
            pasc[quantidadeFila] = paciente;
            quantidadeFila++;
    
            Console.WriteLine("Paciente cadastrado com sucesso!\n");
    
            Console.ReadKey();
            }
        else
        {
            Console.WriteLine("Fila Cheia:");
        }
        }
        
        public void cadastrarPrioritario()
        {
        if (quantidadeFila < 11)
        {
            Console.WriteLine("Nome do paciente:");
            nome = Console.ReadLine();
    
            Console.WriteLine("CPF do paciente:");
            cpf = Console.ReadLine();
    
            Console.WriteLine("Idade do paciente:");
            idade = int.Parse(Console.ReadLine());
    
            Paciente pacientePrioritario = new Paciente(nome, cpf, idade, true);

            for (int i = quantidadeFila - 1; i >= prioridades; i--)
            {
                pasc[i + 1] = pasc[i];
            }

            pasc[prioridades] = pacientePrioritario;
            prioridades++;
            quantidadeFila++;

            Console.WriteLine("Paciente prioritario cadastrado com sucesso!");
        }
        else
        {
            Console.WriteLine("Fila cheia");
        }
        }
        public void atenderPaciente()
        {
            Paciente pacienteAtendido = pasc[0];

        if (quantidadeFila > 0)
        {
            for (int i = 1; i < quantidadeFila; i++)
            {
                pasc[i - 1] = pasc[i];
            }
            pasc[quantidadeFila - 1] = null;
            quantidadeFila--;

            Console.WriteLine($"O Cliente {pacienteAtendido.nome} foi atendido com sucesso");
            Console.ReadKey();
        }
        else
        {
        Console.WriteLine("Consultorio sem pacientes");
        Console.ReadKey();
        }
            
        }
        
        public void listarPaciente()
{
    if (quantidadeFila > 0)
    {
        for (int i = 0; i < pasc.Length; i++)
        {
            if (pasc[i] != null)
            {
                Console.WriteLine($"\nPaciente {i + 1}");
                Console.WriteLine($"Nome:{pasc[i].nome}");
                Console.WriteLine($"Idade:{pasc[i].idade}");
                Console.WriteLine($"CPF:{pasc[i].cpf}");
                Console.WriteLine($"Prioridade:{pasc[i].prioridade}\n");
            }
        }
    }
    else
    {
        Console.WriteLine("Fila Vazia");
    }
    Console.ReadKey();

        } 

    }
}
