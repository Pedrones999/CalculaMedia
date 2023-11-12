using Media.Controle;
using Media.Modelos;
namespace Media;

public partial class TabelaMaterias : Form
{
    private ControleMateria _controleMateria = new();


    public TabelaMaterias()
    {
        InitializeComponent();
    }

    private void NovaMateria(object sender, EventArgs e)
    {
        string nome = CaixaNomeMateria.Text;
        var TodasMaterias = _controleMateria.GetAllMaterias();

        if (String.IsNullOrEmpty(nome) || nome == "Nome para nova materia")
        {
            var Aviso = new Form();
            Aviso.ShowDialog();
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
            edicao.ShowDialog();
        }
    }
}


