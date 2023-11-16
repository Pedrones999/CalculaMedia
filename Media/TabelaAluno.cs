using Media.Controle;
using Media.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media
{
    public partial class TabelaAluno : Form
    {
        Aluno? aluno;
        Materia? materia;

        public TabelaAluno()
        {
            InitializeComponent();
        }

        private void atualizaSugestao()
        {
            var todasMateris = ControleMateria.GetAllMaterias();

            AutoCompleteStringCollection materias = new AutoCompleteStringCollection();

            foreach (var mt in todasMateris)
            {
                materias.Add(mt.ToString());
            }
            NomeMateria.AutoCompleteSource = AutoCompleteSource.CustomSource;
            NomeMateria.AutoCompleteCustomSource = materias;
        }

        private void TabelaAluno_Load(object sender, EventArgs e)
        {
            atualizaSugestao();

            ListaAlunos.DataSource = ControleAluno.GetAllAlunos();

            int alunoIndex = ListaAlunos.SelectedIndex;
            if (ControleAluno.GetAllAlunos().Count >= alunoIndex && alunoIndex >= 0)
            {
                aluno = ControleAluno.GetAllAlunos()[alunoIndex];
                if (aluno != null)
                {
                    CaixaNome.Text = aluno.Nome;
                    ListaMaterias.DataSource = aluno.Materias;
                }
            }


        }

        private void ListaAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int alunoIndex = ListaAlunos.SelectedIndex;
            if (ControleAluno.GetAllAlunos().Count >= alunoIndex && alunoIndex >= 0)
            {
                aluno = ControleAluno.GetAllAlunos()[alunoIndex];
            }
            if (aluno != null)
            {
                CaixaNome.Text = aluno.Nome;
                ListaMaterias.DataSource = aluno.Materias;
                labelAtvs.Text = $"Lista de materias de {aluno.Nome}";
            }

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var TodosAlunos = ControleAluno.GetAllAlunos();

            if (TodosAlunos.Count > 0)
            {
                int IndexMat = ListaAlunos.SelectedIndex;

                Aluno aluno = TodosAlunos[IndexMat];

                aluno.Nome = CaixaNome.Text;

                ControleAluno.Salvar(TodosAlunos);

                ListaAlunos.DataSource = TodosAlunos;
            }
        }
        private void BtnNovoAluno_Click(object sender, EventArgs e)
        {
            string nome = CaixaNome.Text;
            var TodosAlunos = ControleAluno.GetAllAlunos();
            Aluno? nomeRepetido = TodosAlunos.Where(m => m.Nome == nome).FirstOrDefault();

            if (String.IsNullOrEmpty(nome) || nomeRepetido != null)
            {
                DialogResult r = MessageBox.Show("O nome não pode ser repetido nem ficar vazio");
                return;
            }

            var novoAluno = new Aluno(nome);
            TodosAlunos.Add(novoAluno);
            ControleAluno.Salvar(TodosAlunos);

            ListaAlunos.DataSource = ControleAluno.GetAllAlunos();
            ListaAlunos.SelectedIndex = (ListaAlunos.Items.Count - 1);
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            var todosAlunos = ControleAluno.GetAllAlunos();

            if (todosAlunos.Count > 0)
            {
                int IndexAluno = ListaAlunos.SelectedIndex;

                if (IndexAluno > -1)
                {
                    todosAlunos.RemoveAt(IndexAluno);
                }

                ControleAluno.Salvar(todosAlunos);

                ListaAlunos.DataSource = todosAlunos;

                if (todosAlunos.Count == 1)
                {
                    labelAtvs.Text = "Selecione ou crie um aluno para ver as materias";
                }

                int alunoIndex = ListaAlunos.SelectedIndex;
                if (ControleAluno.GetAllAlunos().Count >= alunoIndex && alunoIndex >= 0)
                {
                    aluno = ControleAluno.GetAllAlunos()[alunoIndex];
                    if (aluno != null)
                    {
                        ListaMaterias.DataSource = aluno.Materias;
                    }
                }
            }
        }

        private void BtnAddMateria_Click(object sender, EventArgs e)
        {
            var todosAlunos = ControleAluno.GetAllAlunos();
            if (todosAlunos.Count <= 0)
            {
                return;
            }

            int alunoIndex = ListaAlunos.SelectedIndex;

            if (ControleAluno.GetAllAlunos().Count >= alunoIndex && alunoIndex >= 0)
            {
                aluno = ControleAluno.GetAllAlunos()[alunoIndex];
            }
            var todasMaterias = ControleMateria.GetAllMaterias();
            string nome = NomeMateria.Text;

            materia = todasMaterias.Where(m => m.Nome == nome).FirstOrDefault();

            if (materia == null)
            {
                DialogResult r = MessageBox.Show($"A materia {nome} não existe!");
                return;
            }

            Materia? nomeRepetido = aluno.Materias.Where(m => m.Nome == nome).FirstOrDefault();

            if (nomeRepetido != null)
            {
                DialogResult r = MessageBox.Show($"A materia {nome} ja foi adicionada");
                return;
            }

            aluno.Materias.Add(materia);
            todosAlunos[ListaAlunos.SelectedIndex] = aluno;
            ControleAluno.Salvar(todosAlunos);

            alunoIndex = ListaAlunos.SelectedIndex;
            aluno = ControleAluno.GetAllAlunos()[alunoIndex];
            ListaMaterias.DataSource = aluno.Materias;
        }

        private void ListaMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

            int MatIndex = ListaMaterias.SelectedIndex;
            materia = aluno.Materias[MatIndex];
            NomeMateria.Text = materia.Nome;
            if (MatIndex == -1)
            {
                NomeMateria.Text = "";
            }
        }

        private void LinkMaterias_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var edicao = new TabelaMaterias();
            DialogResult fim = edicao.ShowDialog();
            if (fim != DialogResult.None)
            {
                atualizaSugestao();
                if (ControleAluno.GetAllAlunos().Count > 0)
                {
                    int alunoIndex = ListaAlunos.SelectedIndex;
                    if (ControleAluno.GetAllAlunos().Count >= alunoIndex && alunoIndex >= 0)
                    {
                        aluno = ControleAluno.GetAllAlunos()[alunoIndex];
                    }
                    ListaMaterias.DataSource = aluno.Materias;
                }
            }
        }

        private void BtnRemoverMateria_Click(object sender, EventArgs e)
        {
            var todosAlunos = ControleAluno.GetAllAlunos();
            int alunoIndex;

            if (aluno == null || ListaAlunos.SelectedIndex < 0 || materia == null)
            {
                return;
            }
            aluno.Materias.Remove(materia);
            ListaMaterias.DataSource = aluno.Materias;
            
            todosAlunos[ListaAlunos.SelectedIndex] = aluno;
            ControleAluno.Salvar(todosAlunos);

            alunoIndex = ListaAlunos.SelectedIndex;
            aluno = ControleAluno.GetAllAlunos()[alunoIndex];
            ListaMaterias.DataSource = aluno.Materias;

            if (ListaMaterias.SelectedIndex == -1)
            {
                NomeMateria.Text = "";
            }
        }
        private void BtnPreencher_Click(object sender, EventArgs e)
        {
            if(ListaMaterias.Items.Count <= 0 || aluno == null || materia == null) 
            {
                return;
            }
            
            var preenche = new PreencherNota(aluno.Nome, materia.Nome);
            DialogResult fim = preenche.ShowDialog();
            if (fim != DialogResult.None)
            {
                atualizaSugestao();
                if (ControleAluno.GetAllAlunos().Count > 0)
                {
                    int alunoIndex = ListaAlunos.SelectedIndex;
                    if (ControleAluno.GetAllAlunos().Count >= alunoIndex && alunoIndex >= 0)
                    {
                        aluno = ControleAluno.GetAllAlunos()[alunoIndex];
                    }
                    ListaMaterias.DataSource = aluno.Materias;
                }
            }
        }

    }
}
