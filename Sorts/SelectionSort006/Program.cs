using System;

namespace SelectionSort006 {
    class Program {
        private static CListaLigada miLista = new CListaLigada();
        static void Main(string[] args) {
            // Selection Sort
            miLista.Adicionar(3);
            miLista.Adicionar(15);
            miLista.Adicionar(7);
            miLista.Adicionar(19);
            miLista.Adicionar(11);
            miLista.Adicionar(1);

            miLista.Transversa();

            int i = 0;
            int j = 0;
            int iMin = 0;
            int n = miLista.Cantidad();

            // Recorreremos los elementos
            for (i = 0; i < n; i++) {
                // El índice menor es la posición actual desde que comenzamos
                iMin = i;

                // Encontramos el nuevo índice del menor
                for (j = i + 1; j < n; j++) {
                    if (miLista[j] < miLista[iMin]) {
                        iMin = j;
                    }
                }


                // Intercambiamos la posición actual con el menor
                Swap(i, iMin);
            }
            miLista.Transversa();
        }
        private static void Swap(int i1, int i2) {
            int temp = miLista[i1];
            miLista[i1] = miLista[i2];
            miLista[i2] = temp;
        }
    }
}
