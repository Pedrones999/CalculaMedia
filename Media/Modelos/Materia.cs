using System;
namespace Media.Modelos;

public class Materia
{
	private string _nome;

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

	public double CalculaMedia()
	{
		double total = 0;
		double totalPeso = 0;
        foreach (var atividade in Atvs)
		{
			total = total + atividade.Nota * atividade.Peso;
			totalPeso += atividade.Peso;
		}

		double media = total / totalPeso;

		return media;
	}

	public string NotaPraLetra(double media) 
	{
		if (media < 3.1) 
		{
			return "E";
		}
		
		if (media < 5.0) 
		{
			return "D";
		}
		if (media < 7.0) 
		{
			return "C";
		}
		if (media < 9.0) 
		{
			return "B";
		}
		else 
		{
			return "A";
		}
		
	}
}
