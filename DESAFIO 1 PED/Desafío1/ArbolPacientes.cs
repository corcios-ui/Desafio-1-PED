using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Desafío1
{
    class ArbolPacientes
    {
        private Nodo raiz;
        private Nodo trabajo;
        public int i = 0;



        Graphics area;

        private const int Radio = 300;
        private const int DistanciaH = 400;
        private const int DistanciaV = 400;




        public ArbolPacientes()
        {
            raiz = new Nodo();
        }

        //se generara el metodo insertar nodo
        public Nodo Insertar(string pDato, Nodo pNodo) //donde pDato es el dato a incertar y pNodo el nodo donde se desea insertar
        {

            if (pNodo == null)
            {
                raiz = new Nodo();
                raiz.Dato = pDato;

                //el primer nodo se ingresa como raíz si no hay hijo
                raiz.Hijo = null;

                // de igual manera si no hay hermano y apunta a null no hay hermano
                raiz.Hermano = null;

                return raiz;
            }

            if (pNodo.Hijo == null) //Se verifica si tiene hijos ,sino se inserta el dato como hijo
            {
                Nodo temp = new Nodo();
                temp.Dato = pDato;
                //conectando el nuevo nodo como hijo
                pNodo.Hijo = temp;

                return temp;
            }
            else //ya tiene un hijo, le insertamos un hermano
            {
                trabajo = pNodo.Hijo;

                // insertar el ultimo hermano
                while (trabajo.Hermano != null)
                {
                    trabajo = trabajo.Hermano;
                }


                //creamos nodo temporal 
                Nodo temp = new Nodo();
                temp.Dato = pDato;

                //uniendo el ultimo hermano
                trabajo.Hermano = temp;
                return temp;
            }
        }

            // para recorrer la esructura se realizara una transversa Pre Orden
            public void TransversaPreO(Nodo pNodo)
            {
                if (pNodo == null)

                    return;

                //primer proceso
                for (int n = 0; n < i; n++) ;

                //MessageBox.Show(pNodo.Dato);
                //Console.WriteLine(pNodo.Dato);


                //procesamos a mi hijo
                if (pNodo.Hijo != null)
                {
                    i++;
                    TransversaPreO(pNodo.Hijo);
                    i--;
                }
                // si tengo hermanos los proceso
                if (pNodo.Hermano != null)
                    TransversaPreO(pNodo.Hermano);

            }

        //metodo para dibujar

        public void DibujarNodo(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush encuentro)
        {

            grafo.FillEllipse(encuentro, new Rectangle(75, 40, 100, 25));
            grafo.FillEllipse(Relleno, new Rectangle(75, 40, 100, 25));
            grafo.DrawEllipse(Lapiz, new Rectangle(75, 40, 100, 25));

            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(raiz.ToString(), fuente, RellenoFuente, 75, 40, formato);

        }

        public Nodo MostrarArbol(string gen, string tip, string pre, string nom)
        {


            ArbolPacientes arbol = new ArbolPacientes();
            Nodo raiz = arbol.Insertar("Paciente", null);

            Archivo mostrar = new Archivo();
       
            Nodo n = arbol.Insertar("Genero", raiz);
            arbol.Insertar(gen, n);
            arbol.Insertar(nom, n);

            n = arbol.Insertar("T. Sangre", raiz);
            arbol.Insertar(tip, n);
            arbol.Insertar(nom, n);

            n = arbol.Insertar("Presion", raiz);
            arbol.Insertar(pre, n);
            arbol.Insertar(nom, n);

            return raiz;

        }

        public Nodo BuscarPaciente(string pDato, Nodo pNodo )
        {
            Nodo encontrado = null;

            if (pNodo == null)
                return encontrado;

            if (pNodo.Dato.CompareTo(pDato) == 0)
            {
                encontrado = raiz;
                return encontrado;
            }
            //Procesar nodos hijos
            if (raiz.Hijo != null)
            {
                encontrado = BuscarPaciente(pDato, raiz.Hijo);

                if (encontrado != null)
                    return encontrado;
            }
                    //Si hay hermanos se procesan
                    if(raiz.Hermano !=null)
                    {
                        encontrado = BuscarPaciente(pDato, raiz.Hermano);

                        if (encontrado != null)
                            return encontrado;
                    }
                    return encontrado;
        }
    }
            
}



