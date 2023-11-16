using Media.Controle;
using Media.Modelos;
namespace Media;

public partial class TabelaMaterias : Form
{
    public TabelaMaterias()
    {
        InitializeComponent();
        var todasMaterias = ControleMateria.GetAllMaterias();
    }

    private void NovaMateria(object sender, EventArgs e)
    {
        string nome = CaixaNomeMateria.Text;
        var TodasMaterias = ControleMateria.GetAllMaterias();
        Materia? nomeRepetido = TodasMaterias.Where(m => m.Nome == nome).FirstOrDefault();

        if (String.IsNullOrEmpty(nome) || nomeRepetido != null)
        {
            DialogResult r = MessageBox.Show("O nome não pode ser repetido nem ficar vazio");
            return;

        }

        Materia materia = new(nome);

        TodasMaterias.Add(materia);
        ControleMateria.Salvar(TodasMaterias);
        ListaMaterias.DataSource = TodasMaterias;

    }

    private void TabelaMaterias_Load(object sender, EventArgs e)
    {
        var TodasMaterias = ControleMateria.GetAllMaterias();
        ListaMaterias.DataSource = TodasMaterias;

    }

    private void ListaMaterias_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        var TodasMaterias = ControleMateria.GetAllMaterias();

        int IndexMat = ListaMaterias.SelectedIndex;

        Materia materia = TodasMaterias[IndexMat];

        if (materia.GetType() == typeof(Materia))
        {
            var edicao = new EditMateria(materia);
            ControleMateria.Salvar(TodasMaterias);
            edicao.ShowDialog();
        }
    }

    private void BtnApagar_Click(object sender, EventArgs e)
    {
        var TodasMaterias = ControleMateria.GetAllMaterias();

        if (TodasMaterias.Count > 0)
        {
            int IndexMat = ListaMaterias.SelectedIndex;

            TodasMaterias.RemoveAt(IndexMat);

            ControleMateria.Salvar(TodasMaterias);

            ListaMaterias.DataSource = TodasMaterias;
        }

    }

    private void BtnSalvar_Click(object sender, EventArgs e)
    {
        var TodasMaterias = ControleMateria.GetAllMaterias();
        var todosAlunos = ControleAluno.GetAllAlunos();

        if (TodasMaterias.Count > 0)
        {
            int IndexMat = ListaMaterias.SelectedIndex;

            Materia materia = TodasMaterias[IndexMat];

            foreach (Aluno aluno in todosAlunos)
            {
                foreach (Materia mt in aluno.Materias)
                {
                    if (mt.Nome == materia.Nome)
                    {
                        mt.Nome = CaixaNomeMateria.Text;
                    }
                }
            }

            materia.Nome = CaixaNomeMateria.Text;

            ControleMateria.Salvar(TodasMaterias);
            ControleAluno.Salvar(todosAlunos);

            ListaMaterias.DataSource = TodasMaterias;
        }
        return;
    }

    private void ListaMaterias_SelectedIndexChanged(object sender, EventArgs e)
    {
        CaixaNomeMateria.Text = ListaMaterias.SelectedValue.ToString();
    }
}


