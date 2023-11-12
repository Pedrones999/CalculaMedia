using Media.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Media.Controle
{
    internal class ControleAluno
    {
        public List<Aluno> todosAlunos;

        public void Salvar()
        {
            string praSalvar = JsonSerializer.Serialize(todosAlunos);
            File.WriteAllText(Caminhos.AlunoDb, praSalvar);
        }

        public void Apagar(Aluno aluno)
        {
            todosAlunos.Remove(aluno);
        }

        public void Add(Aluno aluno)
        {
            todosAlunos.Append(aluno);
        }

        public ControleAluno()
        {
            string json = File.ReadAllText(Caminhos.AlunoDb);
            todosAlunos = JsonSerializer.Deserialize<List<Aluno>>(json) ?? new();
        }
    }
}
