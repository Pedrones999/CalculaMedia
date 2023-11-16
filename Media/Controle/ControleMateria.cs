using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading.Tasks;
using Media.Controle;
using Media.Modelos;

public static class ControleMateria
{
    public static void Salvar(List<Materia> materias)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string praSalvar = JsonSerializer.Serialize(materias, options);
        File.WriteAllText(Caminhos.MateriaDb, praSalvar);
    }

    public static List<Materia> GetAllMaterias()
    {
        string json = File.ReadAllText(Caminhos.MateriaDb);
        
        var materias = JsonSerializer.Deserialize<List<Materia>>(json);

        if (materias == null)
        {
            materias = new List<Materia>();
        }
        return materias;
    }

}

