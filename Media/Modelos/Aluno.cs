using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media.Modelos
{
    public class Aluno
    {
        private string _nome;
        public List<Materia> Materias { get; set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("O nome não pode ficar vazio");
                }
                else
                {
                    _nome = value;
                }
            }
        }
        public Aluno(string nome)
        {
            Nome = nome;
            Materias = new List<Materia>();
        }

        public override string ToString() 
        {
            return Nome;
        }
    }
}
