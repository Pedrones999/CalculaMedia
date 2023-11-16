using Media.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Media.Controle
{
    public static class ControleAluno
    {
        public static void Salvar(List<Aluno> alunos)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string praSalvar = JsonSerializer.Serialize(alunos, options);
            File.WriteAllText(Caminhos.AlunoDb, praSalvar);
        }

        public static List<Aluno> GetAllAlunos()
        {
            string json = File.ReadAllText(Caminhos.AlunoDb);

            var alunos = JsonSerializer.Deserialize<List<Aluno>>(json);

            if (alunos == null)
            {
                alunos = new List<Aluno>();
            }

            return alunos;
        }
    }
}
