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
       

        public Paciente(string nome = "", string cpf = "", int idade = 0, bool prioridade = false ) 
        {
            pasc = new Paciente[11];
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.prioridade = prioridade;
        }
        
        public void cadastrarPaciente()
        {
            Console.WriteLine("Nome do paciente:");
            nome = Console.ReadLine();

            Console.WriteLine("CPF do paciente:");
            cpf = Console.ReadLine();

            Console.WriteLine("Idade do paciente:");
            idade = int.Parse(Console.ReadLine());

            Paciente paciente = new Paciente(nome, cpf, idade);

            
        } 

    }
}
