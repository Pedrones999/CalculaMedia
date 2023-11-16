using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media.Modelos;

public class Atividade
{
    private string _nome;
    private double _peso;
    private double _nota;

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
    public double Nota
    {
        get { return _nota; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("O peso da atividade deve ser igual ou maior que 0");
            }
            else
            {
                _nota = value;
            }
        }
    }
    public Atividade(string nome, double peso)
    {
        _nome = nome;
        _peso = peso;
    }

    public override string ToString()
    {
        return Nome;
    }
}

