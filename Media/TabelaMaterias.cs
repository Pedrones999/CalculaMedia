using Media.Controle;
using Media.Modelos;
namespace Media;

public partial class TabelaMaterias : Form
{
    private ControleMateria _controleMateria = new();


    public TabelaMaterias()
    {
        InitializeComponent();
        var todasMaterias = _controleMateria.GetAllMaterias();
    }

    private void NovaMateria(object sender, EventArgs e)
    {
        string nome = CaixaNomeMateria.Text;
        var TodasMaterias = _controleMateria.GetAllMaterias();
        Materia? nomeRepetido = TodasMaterias.Where(m => m.Nome == nome).FirstOrDefault();

        if (String.IsNullOrEmpty(nome) || nomeRepetido != null)
        {
            DialogResult r = MessageBox.Show("O nome não pode ser repetido nem ficar vazio");
            return;

        }

        Materia materia = new(nome);

        TodasMaterias.Add(materia);
        _controleMateria.Salvar(TodasMaterias);
        ListaMaterias.DataSource = TodasMaterias;

    }

    private void TabelaMaterias_Load(object sender, EventArgs e)
    {
        var TodasMaterias = _controleMateria.GetAllMaterias();
        ListaMaterias.DataSource = TodasMaterias;

    }

    private void ListaMaterias_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        var TodasMaterias = _controleMateria.GetAllMaterias();

        int IndexMat = ListaMaterias.SelectedIndex;

        Materia materia = TodasMaterias[IndexMat];

        if (materia.GetType() == typeof(Materia))
        {
            var edicao = new EditMateria(materia);
            _controleMateria.Salvar(TodasMaterias);
            edicao.ShowDialog();
        }
    }

    private void BtnApagar_Click(object sender, EventArgs e)
    {
        var TodasMaterias = _controleMateria.GetAllMaterias();

        if (TodasMaterias.Count > 0)
        {
            int IndexMat = ListaMaterias.SelectedIndex;

            TodasMaterias.RemoveAt(IndexMat);

            _controleMateria.Salvar(TodasMaterias);

            ListaMaterias.DataSource = TodasMaterias;
        }

    }

    private void BtnSalvar_Click(object sender, EventArgs e)
    {
        var TodasMaterias = _controleMateria.GetAllMaterias();

        if (TodasMaterias.Count > 0)
        {
            int IndexMat = ListaMaterias.SelectedIndex;

            Materia materia = TodasMaterias[IndexMat];

            materia.Nome = CaixaNomeMateria.Text;

            _controleMateria.Salvar(TodasMaterias);

            ListaMaterias.DataSource = TodasMaterias;
        }
        return;
    }

    private void ListaMaterias_SelectedIndexChanged(object sender, EventArgs e)
    {
        CaixaNomeMateria.Text = ListaMaterias.SelectedItem.ToString();
    }
}


