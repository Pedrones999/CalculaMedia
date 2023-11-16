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

namespace Media;

public partial class EditMateria : Form
{
    private Materia _materia;
    private List<Atividade> _todasAtvs;

    public EditMateria(Materia materia)
    {
        InitializeComponent();
        _materia = materia;
        _todasAtvs = _materia.Atvs;

    }

    private bool VerificaPeso()
    {
        if (Peso.Text == String.Empty || Double.TryParse(Peso.Text, out var num))
        {
            DialogResult r = MessageBox.Show("O peso deve ser um numero e não pode ficar vazio");
            return false;
        }
        return true;
        
    }

    private void AoCarregar(object sender, EventArgs e)
    {
        label3.Text = $"Atividades de {_materia.Nome}";
        listBox1.DataSource = _materia.Atvs;
        if (_materia.Atvs.Count > 0)
        {
            NomeAtv.Text = listBox1.SelectedItem.ToString();
            Peso.Text = _todasAtvs
                .Where(a => a.Nome == NomeAtv.Text)
                .FirstOrDefault().Peso.ToString();
        }
        else
        {
            return;
        }
    }

    private void ClickNovaAtv(object sender, EventArgs e)
    {
        var TodasMaterias = ControleMateria.GetAllMaterias();
        string? nome = NomeAtv.Text;
        double peso;
        _todasAtvs = _materia.Atvs;
        Atividade? repetida = _todasAtvs.Where(a => a.Nome == nome).FirstOrDefault();

        if (repetida != null || nome == null)
        {
            DialogResult r = MessageBox.Show("O nome não pode ser repetido ou ficar vazio");
            return;
        }

        try
        {
            peso = double.Parse(Peso.Text);
        }

        catch
        {
            DialogResult r = MessageBox.Show("O campo peso deve ser um numero inteiro ou com virgula");
            return;
        }

        Atividade Atv = new(nome, peso);
        Materia materia = TodasMaterias.Where(m => m.Nome == _materia.Nome).FirstOrDefault();
        materia.Atvs.Add(Atv);
        _materia.Atvs.Add(Atv);
        ControleMateria.Salvar(TodasMaterias);

        listBox1.DataSource = materia.Atvs;
        listBox1.SelectedItem = Atv;
    }

    public void SalvarAtv(object sender, EventArgs e)
    {
        if (listBox1.Items.Count != 0 && VerificaPeso())
        {
            var TodasMaterias = ControleMateria.GetAllMaterias();
            var materia = TodasMaterias.Where(m => m.Nome == _materia.Nome).FirstOrDefault();

            _todasAtvs = materia.Atvs;

            var atv = _todasAtvs[listBox1.SelectedIndex];

            atv.Nome = NomeAtv.Text;
            atv.Peso = double.Parse(Peso.Text);

            ControleMateria.Salvar(TodasMaterias);
            listBox1.DataSource = materia.Atvs;
            _materia.Atvs = materia.Atvs;
        }


    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        NomeAtv.Text = listBox1.SelectedItem.ToString();
        Peso.Text = _todasAtvs
            .Where(a => a.Nome == NomeAtv.Text)
            .FirstOrDefault().Peso.ToString();
    }

    private void BtnApagaAtv_Click(object sender, EventArgs e)
    {
        if (listBox1.Items.Count != 0)
        {
            var TodasMaterias = ControleMateria.GetAllMaterias();
            var materia = TodasMaterias.Where(m => m.Nome == _materia.Nome).FirstOrDefault();
            int atvIndex = listBox1.SelectedIndex;

            materia.Atvs.RemoveAt(atvIndex);
            ControleMateria.Salvar(TodasMaterias);
            listBox1.DataSource = materia.Atvs;
            _materia.Atvs = materia.Atvs;
        }
        else
        {
            return;
        }

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
}
