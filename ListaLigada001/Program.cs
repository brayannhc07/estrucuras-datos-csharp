using System;

namespace ListaLigada001 {
    class Program {
        static void Main(string[] args) {
            CListaLigada miLista = new CListaLigada();

            miLista.Adicionar(3);
            miLista.Adicionar(5);
            miLista.Adicionar(7);
            miLista.Adicionar(9);
            miLista.Adicionar(11);
            miLista.Adicionar(15);

            miLista.Transversa();
            // Console.WriteLine(miLista.EstaVacio());

            // miLista.Vaciar();

            // miLista.Transversa();
            // Console.WriteLine(miLista.EstaVacio());

            CNodo encontrado = miLista.Buscar(7);
            Console.WriteLine(encontrado);

            encontrado = miLista.Buscar(17);
            Console.WriteLine(encontrado);

            int indice = miLista.BuscarIndice(3);
            Console.WriteLine(indice);

            indice = miLista.BuscarIndice(13);
            Console.WriteLine(indice);
        }
    }
}
