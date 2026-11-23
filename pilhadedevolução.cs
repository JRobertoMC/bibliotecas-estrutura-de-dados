public class PilhaDevolucoes
{
    private Livro[] elementos;
    private int topo;
    private int capacidade;

    public PilhaDevolucoes(int capacidadeMaxima)
    {
        capacidade = capacidadeMaxima;
        elementos = new Livro[capacidade];
        topo = -1;
    }

    public bool EstaVazia()
    {
        if (topo == -1)
        {
            return true;
        }
        return false;
    }

    public bool EstaCheia()
    {
        if (topo == capacidade - 1)
        {
            return true;
        }
        return false;
    }

    public bool Empilhar(Livro livro)
    {
        if (EstaCheia() == true)
        {
            return false;
        }

        topo = topo + 1;
        elementos[topo] = livro;
        return true;
    }

    public Livro Desempilhar()
    {
        if (EstaVazia() == true)
        {
            return null;
        }

        Livro livroDoTopo = elementos[topo];
        elementos[topo] = null;
        topo = topo - 1;
        return livroDoTopo;
    }

    public Livro VerTopo()
    {
        if (EstaVazia() == true)
        {
            return null;
        }

        return elementos[topo];
    }

    
    public Livro[] ListarElementos()
    {
        if (EstaVazia() == true)
        {
            return new Livro[0];
        }

        Livro[] lista = new Livro[topo + 1];
        int indiceLista = 0;

        // Percorre do topo para a base
        for (int i = topo; i >= 0; i--)
        {
            lista[indiceLista] = elementos[i];
            indiceLista = indiceLista + 1;
        }

        return lista;
    }
}
