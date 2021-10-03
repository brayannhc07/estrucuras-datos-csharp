using System;

namespace QuickSort008 {
    class Program {
        private static CListaLigada miLista = new CListaLigada();
        static void Main(string[] args) {
            miLista.Adicionar(3);
            miLista.Adicionar(15);
            miLista.Adicionar(7);
            miLista.Adicionar(19);
            miLista.Adicionar(11);
            miLista.Adicionar(1);

            miLista.Transversa();

            QuickSort(0, miLista.Cantidad() - 1);

            miLista.Transversa();
        }

        private static void Swap(int i1, int i2) {
            int temp = miLista[i1];
            miLista[i1] = miLista[i2];
            miLista[i2] = temp;
        }

        public static int Particion(int pInicio, int pFin) {
            int pivote = 0;
            int iPivote = 0;
            int n = 0;

            // Seleccionamos el último pivote
            pivote = miLista[pFin];

            // Ponemos el índice de pivote con el índice del inicio
            iPivote = pInicio;

            // Recorremos la lista de pivote con el indice de inicio
            for (n = pInicio; n < pFin; n++) {
                // Si el elemento en el índice n es menor o igual al pivote 
                if (miLista[n] <= pivote) {
                    // Intercambiamos el elemento en n con el que se encuentre en el indice de pivote
                    Swap(n, iPivote);

                    // Incrementamos el indice del pivote
                    iPivote++;
                }
            }

            // Hacemos el swap final para colocar el pivote donde corresponde
            Swap(iPivote, pFin);

            // Regresamos el índice del pivote
            return iPivote;
        }

        public static void QuickSort(int pInicio, int pFin) {
            int iPivote = 0;

            // Caso base, un elemento o fragmento inválido
            if (pInicio >= pFin) return;

            // Obtenemos el índice del pivote para el fragmento con el que trabajamos
            iPivote = Particion(pInicio, pFin);

            // Casos inductivos 
            QuickSort(pInicio, iPivote - 1); // Fragmento a la izquierda del pivote
            QuickSort(iPivote + 1, pFin); // Fragmento a la derecha del pivote
        }
    }
}
