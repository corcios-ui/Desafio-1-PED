using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío1
{
    class Nodo
    {
        private string dato;
        private Nodo hijo;
        private Nodo hermano;

        public string Dato { get => dato; set => dato = value; }
        public Nodo Hijo { get => hijo; set => hijo = value; }
        public Nodo Hermano { get => hermano; set => hermano = value; }

        public Nodo()
        {
            dato = "";
            hijo = null;
            hermano = null;

        }
    }
}
