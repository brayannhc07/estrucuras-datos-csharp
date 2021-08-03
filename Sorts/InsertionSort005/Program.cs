using System;

namespace InsertionSort005 {
    class Program {
        private static CListaLigada miLista = new CListaLigada();
        static void Main(string[] args) {
            // Insertion Sort
            miLista.Adicionar(3);
            miLista.Adicionar(15);
            miLista.Adicionar(7);
            miLista.Adicionar(19);
            miLista.Adicionar(11);
            miLista.Adicionar(1);


            miLista.Transversa();

            int cantidad = miLista.Cantidad();
            int i = 0;
            int posAgujero = 0;
            int dato = 0;

            // Recorreremos los elementos
            // for (i = 1; i < cantidad; i++) {
            //     // obtenemos el dato
            //     dato = miLista[i];

            //     // Indicamos la posición del agujero
            //     posAgujero = i;

            //     // Recorremos los elementos hacia el agujero
            //     while (posAgujero > 0 && miLista[posAgujero - 1] > dato) {
            //         miLista[posAgujero] = miLista[posAgujero - 1];
            //         posAgujero = posAgujero - 1;
            //     }

            //     // Le colocamos al agujero el dato correspondiente
            //     miLista[posAgujero] = dato;
            // }

            // Otra forma de inplementar, usando swap para mejorar la anterior
            for (i = 0; i < cantidad; i++) {
                posAgujero = i;

                while (posAgujero > 0 && miLista[posAgujero] < miLista[posAgujero - 1]) {
                    Swap(posAgujero, posAgujero - 1);
                    posAgujero = posAgujero - 1;
                }
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
