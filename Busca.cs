public class Busca
{
    public static int BuscaLinearPorTitulo(Livro[] acervo, int totalLivros, string tituloProcurado)
    {
        for (int i = 0; i < totalLivros; i++)
        {
            if (acervo[i].Titulo == tituloProcurado)
            {
                return i;
            }
        }

        return -1;
    }

    public static int BuscaBinariaPorId(Livro[] acervo, int totalLivros, int idProcurado)
    {
        int inicio = 0;
        int fim = totalLivros - 1;

        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;

            if (acervo[meio].Id == idProcurado)
            {
                return meio;
            }
            else if (acervo[meio].Id < idProcurado)
            {
                inicio = meio + 1;
            }
            else
            {
                fim = meio - 1;
            }
        }

        return -1;
    }
}
