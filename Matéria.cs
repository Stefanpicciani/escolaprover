using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaProver
{
    public class Materia
    {
        public int IDMateria { get; set; }
        public string NomeMateria { get; set; }
       
        public Materia()
        {

        }
        public Materia(int idMateria, string nomeMateria)
        {
            IDMateria = idMateria;
            NomeMateria = nomeMateria;
        }
    }
}
