using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Media.Controle;
using Media.Modelos;

namespace Media
{
    public partial class EditMateria : Form
    {
        private Materia _materia;
        public EditMateria(Materia materia)
        {
            InitializeComponent();
            _materia = materia;

        }

        private void AoCarregar(object sender, EventArgs e)
        {
            NomeMateria.Text = _materia.Nome;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PainelMateria_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
