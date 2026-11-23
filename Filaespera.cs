public class FilaEspera
{
    private PedidoReserva[] elementos;
    private int inicio;
    private int fim;
    private int quantidade;
    private int capacidade;

    public FilaEspera(int capacidadeMaxima)
    {
        capacidade = capacidadeMaxima;
        elementos = new PedidoReserva[capacidade];
        inicio = 0;
        fim = -1;
        quantidade = 0;
    }

    public bool EstaVazia()
    {
        if (quantidade == 0)
        {
            return true;
        }
        return false;
    }

    public bool EstaCheia()
    {
        if (quantidade == capacidade)
        {
            return true;
        }
        return false;
    }

    public bool Enfileirar(PedidoReserva pedido)
    {
        if (EstaCheia() == true)
        {
            return false;
        }

        fim = (fim + 1) % capacidade;
        elementos[fim] = pedido;
        quantidade = quantidade + 1;
        return true;
    }

    public PedidoReserva Desenfileirar()
    {
        if (EstaVazia() == true)
        {
            return null;
        }

        PedidoReserva primeiroDaFila = elementos[inicio];
        elementos[inicio] = null;
        inicio = (inicio + 1) % capacidade;
        quantidade = quantidade - 1;
        return primeiroDaFila;
    }

    // Método útil para mostrar a fila de espera na tela do site
    public PedidoReserva[] ListarElementos()
    {
        if (EstaVazia() == true)
        {
            return new PedidoReserva[0];
        }

        PedidoReserva[] lista = new PedidoReserva[quantidade];
        int indiceAtual = inicio;

        for (int i = 0; i < quantidade; i++)
        {
            lista[i] = elementos[indiceAtual];
            indiceAtual = (indiceAtual + 1) % capacidade;
        }

        return lista;
    }
}
