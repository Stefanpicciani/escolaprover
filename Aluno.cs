using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaProver
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string NomeAluno { get; set; }
        public string CpfAluno { get; set; }
        public double TelefoneAluno { get; set; }  
        public string DataNascimento { get; set; } 

        public Aluno()
        {

        }

        public Aluno(int matricula, string nomeAluno, string cpfAluno, double telefoneAluno, string dataNascimento)
        {
            Matricula = matricula;
            NomeAluno = nomeAluno;
            CpfAluno = cpfAluno;
            TelefoneAluno = telefoneAluno;
            DataNascimento = dataNascimento;
        }

      
    }
}
