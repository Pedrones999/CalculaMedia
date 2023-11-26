using iText.Kernel.Colors;
using Media.Modelos;
using System;
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
    public partial class ConfigBoletim : Form
    {
        public Aluno aluno;
        public string caminho;
        public int periodos;
        public int periodoPreenchido;
        public bool notaLetra;

        public int[] bimestres = new int[] { 1, 2, 3, 4 };
        public int[] trimestres = new int[] { 1, 2, 3 };

        public ConfigBoletim(Aluno al)
        {
            InitializeComponent();
            aluno = al;
            this.Text = "Boletim de " + aluno.ToString();

            checkBimestre.Checked = false;
            periodos = 3;
            periodo.DataSource = trimestres;

            checkTrimestre.Checked = true;
            caminho = Application.StartupPath.Remove(Application.StartupPath.Length - 1);
            caixaCaminho.Text = caminho;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConfigBoletim_Load(object sender, EventArgs e)
        {

        }

        private void AchaPasta_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            caminho = folderBrowserDialog1.SelectedPath;
            caixaCaminho.Text = caminho;
        }

        private void checkBimestre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBimestre.Checked)
            {
                checkTrimestre.Checked = false;
                periodos = 4;
                periodo.DataSource = bimestres;
            }
            if (!checkBimestre.Checked)
            {
                checkTrimestre.Checked = true;
                periodos = 3;
                periodo.DataSource = trimestres;
            }
        }
        private void checkTrimestre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTrimestre.Checked)
            {
                checkBimestre.Checked = false;
                periodos = 3;
                periodo.DataSource = trimestres;
            }
            if (!checkTrimestre.Checked)
            {
                checkBimestre.Checked = true;
                periodos = 4;
                periodo.DataSource = bimestres;
            }
        }

        private void checkNum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNum.Checked)
            {
                checkLetra.Checked = false;
                notaLetra = true;
            }
        }
        private void checkLetra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLetra.Checked)
            {
                checkNum.Checked = false;
                notaLetra = false;
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            periodoPreenchido = int.Parse(periodo.Text);
            GeradorPDF criador = new GeradorPDF(aluno, caminho, notaLetra, periodos, periodoPreenchido);

            criador.CriarBoletim();

            DialogResult aviso = MessageBox.Show($"O arquivo foi salvo em {caminho}");
        }
    }
}
