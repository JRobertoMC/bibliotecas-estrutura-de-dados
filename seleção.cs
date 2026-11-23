public class Selecao
{
    public static Livro[] SelecionarPorCategoria(Livro[] acervo, int totalLivros, string categoriaDesejada)
    {
        int contador = 0;

        for (int i = 0; i < totalLivros; i++)
        {
            if (acervo[i].Categoria == categoriaDesejada)
            {
                contador = contador + 1;
            }
        }

        Livro[] resultado = new Livro[contador];
        
        int posicao = 0;

        for (int i = 0; i < totalLivros; i++)
        {
            if (acervo[i].Categoria == categoriaDesejada)
            {
                resultado[posicao] = acervo[i];
                posicao = posicao + 1;
            }
        }

        return resultado;
    }

    public static Livro[] SelecionarPorFaixaDeAno(Livro[] acervo, int totalLivros, int anoMinimo, int anoMaximo)
    {
        int contador = 0;
        for (int i = 0; i < totalLivros; i++)
        {
            if (acervo[i].Ano >= anoMinimo && acervo[i].Ano <= anoMaximo)
            {
                contador = contador + 1;
            }
        }

        Livro[] resultado = new Livro[contador];
        int posicao = 0;

        for (int i = 0; i < totalLivros; i++)
        {
            if (acervo[i].Ano >= anoMinimo && acervo[i].Ano <= anoMaximo)
            {
                resultado[posicao] = acervo[i];
                posicao = posicao + 1;
            }
        }

        return resultado;
    }
}
