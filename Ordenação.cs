public class Ordenacao
{
    public static void BubbleSortPorTitulo(Livro[] acervo, int totalLivros)
    {
        for (int i = 0; i < totalLivros - 1; i++)
        {
            for (int j = 0; j < totalLivros - 1 - i; j++)
            {
                string titulo1 = acervo[j].Titulo;
                string titulo2 = acervo[j + 1].Titulo;

                int menorTamanho = titulo1.Length;
                if (titulo2.Length < menorTamanho)
                {
                    menorTamanho = titulo2.Length;
                }

                bool precisaTrocar = false;

                for (int k = 0; k < menorTamanho; k++)
                {
                    if (titulo1[k] > titulo2[k])
                    {
                        precisaTrocar = true;
                        break;
                    }
                    else if (titulo1[k] < titulo2[k])
                    {
                        precisaTrocar = false;
                        break;
                    }
                }

                if (precisaTrocar == true)
                {
                    Livro temp = acervo[j];
                    acervo[j] = acervo[j + 1];
                    acervo[j + 1] = temp;
                }
            }
        }
    }

    public static void BubbleSortPorId(Livro[] acervo, int totalLivros)
    {
        for (int i = 0; i < totalLivros - 1; i++)
        {
            for (int j = 0; j < totalLivros - 1 - i; j++)
            {
                if (acervo[j].Id > acervo[j + 1].Id)
                {
                    Livro temp = acervo[j];
                    acervo[j] = acervo[j + 1];
                    acervo[j + 1] = temp;
                }
            }
        }
    }

    public static void QuickSortPorAno(Livro[] acervo, int inicio, int fim)
    {
        if (inicio < fim)
        {
            int indicePivo = ParticionarPorAno(acervo, inicio, fim);
            QuickSortPorAno(acervo, inicio, indicePivo - 1);
            QuickSortPorAno(acervo, indicePivo + 1, fim);
        }
    }

    private static int ParticionarPorAno(Livro[] acervo, int inicio, int fim)
    {
        Livro pivo = acervo[fim];
        int i = inicio - 1;

        for (int j = inicio; j < fim; j++)
        {
            if (acervo[j].Ano <= pivo.Ano)
            {
                i = i + 1;
                Livro temp = acervo[i];
                acervo[i] = acervo[j];
                acervo[j] = temp;
            }
        }

        Livro tempPivo = acervo[i + 1];
        acervo[i + 1] = acervo[fim];
        acervo[fim] = tempPivo;

        return i + 1;
    }
}
