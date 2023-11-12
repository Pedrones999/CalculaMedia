using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media.Modelos
{
    public class Aluno
    {
        private Guid _id;
        private string _nome;
        public List<Materia> Materias;

        public Guid Id
        {
            get { return _id; }
        }
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

            _id = Guid.NewGuid();
            Materias = new List<Materia>();
        }
    }
}
