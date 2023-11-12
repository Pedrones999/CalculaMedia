using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media.Modelos;

public class Atividade
{
    private Guid _id;
    private string _nome;
    private double _peso;

    public Guid Id
    {
        get { return _id; } 
    }

    public string Nome
    {
        get { return _nome; }
        set 
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("O nome não pode ficar vazio");
            }
            else
            {
                _nome = value;
            }
        }
    }
    public double Peso
    {
        get { return _peso; }
        set 
        {
            if (value <= 0)
            {
                throw new ArgumentException("O peso da atividade deve ser maior que 0");
            }
            else
            {
                _peso = value;  
            }
        }
    }
    public Atividade(string nome, double peso)
    {
        _id = Guid.NewGuid();
        _nome = nome;
        _peso = peso;
    }
}

