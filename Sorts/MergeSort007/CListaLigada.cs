using System;

namespace MergeSort007 {
    class CListaLigada {
        // Es el ancla o encabezado de la lista
        private CNodo ancla;
        // Esta variable de referencia nos ayuda a trabajar con la lista
        private CNodo trabajo;

        // Esta variable de referencia apoya en ciertas operaciones de la lista
        private CNodo trabajo2;

        public CListaLigada() {
            // Instanciamos el ancla
            ancla = new CNodo();

            // Como es una lista vacía su siguiente es null
            ancla.Siguiente = null;
        }

        // Recorre toda la lista
        public void Transversa() {
            // Tabajo al inicio
            trabajo = ancla;

            // Recorreremos hasta encontrar el final
            while (trabajo.Siguiente != null) {
                // Avanzamos trabajo 
                trabajo = trabajo.Siguiente;

                // Obtenemos el dato y lo mostramos
                int d = trabajo.Dato;

                Console.Write($"{d}, ");
            }

            // Bajamos la línea
            Console.WriteLine();
        }

        // Adiciona un nuevo elemento
        // La adición siempre va al final
        public void Adicionar(int pDato) {
            // Trabajo de inicio
            trabajo = ancla;

            // Recorremos hasta encontrar el final
            while (trabajo.Siguiente != null) {
                // Avanzamos trabajo
                trabajo = trabajo.Siguiente;
            }

            // Creamos el nuevo nodo
            CNodo temp = new CNodo();

            // Insertamos el dato
            temp.Dato = pDato;

            // Finalizamos correctamente 
            temp.Siguiente = null;

            // Ligamos el último nodo encontrado con el recién creado 
            trabajo.Siguiente = temp;
        }

        // Vaciar la lista
        public void Vaciar() {
            ancla.Siguiente = null;

            // En lenguajes no administrados, hay que liberar la memoria adecuadamente
            // Aquí aprovechamos el recolector de basura 
        }

        // Indica si la lista está vacía o no
        public bool EstaVacio() {
            return ancla.Siguiente == null;
        }

        // Regresar el nodo con la primer coincidencia del dato
        public CNodo Buscar(int pDato) {
            if (!EstaVacio()) {
                trabajo2 = ancla;

                // Recorremos para ver si lo encontramos
                while (trabajo2.Siguiente != null) {
                    trabajo2 = trabajo2.Siguiente;

                    // Al encontralo lo regresamos
                    if (trabajo2.Dato == pDato) {
                        return trabajo2;
                    }
                }
            }
            // Sino se encuentra, devuelve null
            return null;
        }

        // Busca el indice donde se encuentra la primera coincidencia del dato
        public int BuscarIndice(int pDato) {
            int n = -1;

            trabajo = ancla;

            while (trabajo.Siguiente != null) {
                trabajo = trabajo = trabajo.Siguiente;
                n++;

                if (trabajo.Dato == pDato) {
                    return n;
                }
            }
            return -1;
        }

        // Encuentra el nodo anterior
        // Si está en el primer nodo, se regresa el ancla
        // Es el dato no existe, se regresa el último nodo
        public CNodo BuscarAnterior(int pDato) {
            trabajo2 = ancla;

            while (trabajo2.Siguiente != null && trabajo2.Siguiente.Dato != pDato) {
                trabajo2 = trabajo2.Siguiente;
            }
            return trabajo2;
        }

        // Borrar la primera coincidencia del dato
        public void Borrar(int pDato) {
            // Verificamos que se tengan datos
            if (EstaVacio()) {
                return;
            }

            // Buscamos los nodos con los que trabajaremos
            CNodo anterior = BuscarAnterior(pDato);

            CNodo encontrado = Buscar(pDato);

            // Si no hay nodo a borrar, salimos
            if (encontrado is null) {
                return;
            }

            // Brincamos el nodo
            anterior.Siguiente = encontrado.Siguiente;

            // Quitamos el actual de la lista
            encontrado.Siguiente = null;
        }

        // Inserta el dato pValor después de la primera ocurrencia del dato pasado a pDonde
        public void Insertar(int pDonde, int pValor) {
            // Encontramos la posición donde vámos a insertar
            trabajo = Buscar(pDonde);

            // Verificamos que exista donde vamos a insertar
            if (trabajo == null) {
                return;
            }

            // Creamos el nodo temporal a insertar
            CNodo temp = new CNodo();
            temp.Dato = pValor;

            // Conectamos el temporal a la lista
            temp.Siguiente = trabajo.Siguiente;

            // Conectamos trabajo a temporal
            trabajo.Siguiente = temp;
        }

        public void InsertarInicio(int pDato) {
            // Creamos un nodo temporal
            CNodo temp = new CNodo();
            temp.Dato = pDato;

            // Conectamos el temporal a la lista
            temp.Siguiente = ancla.Siguiente;

            // Conectamos el ancla al temporal
            ancla.Siguiente = temp;
        }

        // Obtenemos la referencia al nodo dado el índice
        public CNodo ObtenPorIndice(int pIndice) {
            CNodo trabajo2 = null;
            int indice = -1;

            trabajo = ancla;

            while (trabajo.Siguiente != null) {
                trabajo = trabajo.Siguiente;
                indice++;

                if (indice == pIndice) {
                    trabajo2 = trabajo;
                }
            }
            return trabajo2;
        }

        // Creamos un indexer
        public int this[int pIndice] {
            get {
                // Esto puede crear una exepcion si trabajo es null
                // Colocar el código de seguridad o usar int?

                trabajo = ObtenPorIndice(pIndice);
                return trabajo.Dato;
            }
            set {
                trabajo = ObtenPorIndice(pIndice);
                if (trabajo != null) {
                    trabajo.Dato = value;
                }
            }
        }
        // Cuenta la cantidad de elementos en la lista
        public int Cantidad() {
            trabajo = ancla;
            int n = 0;

            while (trabajo.Siguiente != null) {
                trabajo = trabajo.Siguiente;
                n++;
            }
            return n;
        }
    }
}