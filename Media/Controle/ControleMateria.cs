using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Media.Controle;
using Media.Modelos;

public class ControleMateria
{
    public void Salvar(List<Materia> materias)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string praSalvar = JsonSerializer.Serialize(materias, options);
        File.WriteAllText(Caminhos.MateriaDb, praSalvar);
    }

    public List<Materia?> GetAllMaterias()
    {
        string json = File.ReadAllText(Caminhos.MateriaDb);
        
        var materias = JsonSerializer.Deserialize<List<Materia?>>(json);

        return materias;
    }

    public ControleMateria()
    {
        string json = File.ReadAllText(Caminhos.MateriaDb);
        if(!String.IsNullOrEmpty(json))
        {
            Materia[]? materiasArray = JsonSerializer.Deserialize<Materia[]>(json);
        }
    }
}

