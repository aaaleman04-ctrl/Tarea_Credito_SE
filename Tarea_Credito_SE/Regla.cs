using System;
using System.Collections.Generic;

namespace Tarea_Credito_SE
{
    public class Regla
    {
        public string Nombre { get; }

        public Func<HashSet<string>, bool> Condicion { get; }

        public string Conclusion { get; }

        public Regla(string nombre, Func<HashSet<string>, bool> condicion, string conclusion)
        {
            Nombre = nombre;
            Condicion = condicion;
            Conclusion = conclusion;
        }
    }
}