using System;

namespace MergeSort007 {
    class Program {
        private static CListaLigada miLista = new CListaLigada();
        static void Main(string[] args) {

            // CListaLigada l = new CListaLigada();
            // l.Adicionar(6);
            // l.Adicionar(7);
            // l.Adicionar(9);
            // l.Adicionar(11);

            // CListaLigada r = new CListaLigada();
            // r.Adicionar(8);
            // r.Adicionar(10);
            // r.Adicionar(12);
            // r.Adicionar(13);

            // CListaLigada merged = Merge(l, r);

            // merged.Transversa();

            ////////////////////////////////////////

            miLista.Adicionar(3);
            miLista.Adicionar(15);
            miLista.Adicionar(7);
            miLista.Adicionar(19);
            miLista.Adicionar(11);
            miLista.Adicionar(1);

            miLista.Transversa();

            CListaLigada ordenada = MergeSort(miLista);
            ordenada.Transversa();
        }

        public static CListaLigada Merge(CListaLigada listaIzq, CListaLigada listaDer) {
            //  Para que funcione correctamente las listas debe estar ordenadas

            // lista donde se unen
            CListaLigada unida = new CListaLigada();

            // Indices en cada lista
            int indiceI = 0;
            int indiceD = 0;

            // Cantidad de elementos en cada lista
            int cantI = listaIzq.Cantidad();
            int cantD = listaDer.Cantidad();

            // Recorremos mientras las dos listas tengan elementos sin procesar
            while (indiceI < cantI && indiceD < cantD) {
                // Si el de la izquierda es menor o igual, adicionamos el de la izquierda
                if (listaIzq[indiceI] <= listaDer[indiceD]) {
                    unida.Adicionar(listaIzq[indiceI]);

                    // Avanzamos el índice izquierdo
                    indiceI++;
                } else {
                    // Si el de la derecha es menor, adicionamos el de la derecha
                    unida.Adicionar(listaDer[indiceD]);

                    // Avanzamos el índice derecho
                    indiceD++;
                }
            }

            // Si sobraron elementos en la lista izquierda, los ponemos todos
            while (indiceI < cantI) {
                unida.Adicionar(listaIzq[indiceI]);
                indiceI++;
            }
            // Si sobraron elementos en la lista derecha, los ponemos todos
            while (indiceD < cantD) {
                unida.Adicionar(listaDer[indiceD]);
                indiceD++;
            }

            // Regresamos la lista unida
            return unida;
        }

        public static CListaLigada MergeSort(CListaLigada pLista) {
            // Cantidad de elementoss en la lista
            int cantidad = pLista.Cantidad();
            int n = 0;

            // Caso base, una lista de un solo elemento ya está ordenado
            if (cantidad < 2) {
                return pLista;
            }

            // Obtenemos el punto medio de la lista
            int mitad = cantidad / 2;

            CListaLigada izquierda = new CListaLigada();
            CListaLigada derecha = new CListaLigada();

            // Adicionamos a la izquierda desde el inicio hasta antes de la mitad
            for (n = 0; n < mitad; n++) {
                izquierda.Adicionar(pLista[n]);
            }

            for (n = mitad; n < cantidad; n++) {
                derecha.Adicionar(pLista[n]);
            }

            // Casos inductivos
            // Hacemos el MergeSort de las listas Izquierda y Derecha
            CListaLigada tempI = MergeSort(izquierda);
            CListaLigada tempD = MergeSort(derecha);

            // Hacemos el merge de lo que nos regresa el caso inductivo
            CListaLigada ordenada = Merge(tempI, tempD);

            // Regresamos la lista ordenada
            return ordenada;
        }
    }
}
