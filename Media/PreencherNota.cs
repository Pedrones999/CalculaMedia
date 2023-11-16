using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Media.Modelos;
using Media.Controle;

namespace Media
{
    public partial class PreencherNota : Form
    {
        Aluno aluno;
        Materia materia;
        Atividade atv;
        List<Atividade> Atvs;
        public PreencherNota(string nomeAluno, string nomeMateria)
        {
            InitializeComponent();
            aluno = ControleAluno.GetAllAlunos().Where(a => a.Nome == nomeAluno).FirstOrDefault();
            materia = aluno.Materias.Where(m => m.Nome == nomeMateria).FirstOrDefault();
            Atvs = materia.Atvs;
        }
        private bool VerificaNota()
        {
            if (CaixaNota.Text == String.Empty || Double.TryParse(CaixaNota.Text, out var num) == false)
            {
                DialogResult r = MessageBox.Show("A nota deve ser um numero e não pode ficar vazia");
                return false;
            }
            return true;

        }
        public void aoCarregar(object sender, EventArgs e)
        {
            ListaAtvs.DataSource = materia.Atvs;
        }

        public void trocaIndex(object sender, EventArgs e)
        {
            int AtvIndex = ListaAtvs.SelectedIndex;
            atv = Atvs[AtvIndex];
            CaixaNota.Text = atv.Nota.ToString();
            NomeAtv.Text = atv.Nome;
        }

        public void SalvaNota(object sender, EventArgs e)
        {
            if (VerificaNota())
            {
                string nota = ControleMateria.tratamentoDouble(CaixaNota.Text);
                atv.Nota = double.Parse(nota);

                var todosAlunos = ControleAluno.GetAllAlunos();
                Aluno alunoReal = todosAlunos.Where(a => a.Nome == aluno.Nome).FirstOrDefault();
                int alunoIndex = todosAlunos.IndexOf(alunoReal);

                todosAlunos[alunoIndex] = aluno;

                ControleAluno.Salvar(todosAlunos);
            }
        }

    }
}
