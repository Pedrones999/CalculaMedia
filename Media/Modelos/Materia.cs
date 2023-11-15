using System;
namespace Media.Modelos;

public class Materia
{
	private Guid _id = Guid.NewGuid();
	private string _nome;

    public Guid Id
	{
		get { return _id; }
		private set 
		{
			_id = value;
		}
	}
	public string Nome 
	{
		get { return _nome; }
		set
		{
			if(String.IsNullOrEmpty(value))
			{
				throw new ArgumentNullException("O nome não pode ficar vazio");
			}
			else
			{
				_nome = value;
			}
		}
	}
	public List<Atividade> Atvs { get; set; }

	public Materia(string nome)
	{
		Nome = nome;
		Atvs = new List<Atividade>();
	}

    public override string ToString()
    {
        return Nome;
    }

}
