using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaProver
{
    public class Turma
    {
        public int NumeroTurma { get; set; }
        public string NomeTurma { get; set; }
        public string DescricaoTurma { get; set; }  
        public Turma()
        {

        }
        public Turma(int numeroTurma, string nomeTurma, string descricaoTurma)
        {
            NumeroTurma = numeroTurma;
            NomeTurma = nomeTurma;
            DescricaoTurma = descricaoTurma;
        }
    }
}
