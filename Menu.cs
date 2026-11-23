using System;

public class Menu
{
    private Biblioteca biblioteca;

    public Menu(Biblioteca bibliotecaSistema)
    {
        biblioteca = bibliotecaSistema;
    }

    public void Exibir()
    {
        int opcao = -1;

        while (opcao != 0)
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE BIBLIOTECA ===");
            Console.WriteLine("1 - Ordenar Acervo por Ordem Alfabética (Título)");
            Console.WriteLine("2 - Ordenar Acervo por Ano de Publicação");
            Console.WriteLine("3 - Buscar Livro por Título");
            Console.WriteLine("4 - Buscar Livro por Código (ID)");
            Console.WriteLine("5 - Filtrar Livros por Categoria");
            Console.WriteLine("6 - Filtrar Livros por Período (Ano)");
            Console.WriteLine("7 - Registrar Devolução de Livro");
            Console.WriteLine("8 - Conferir Próxima Devolução (Desempilhar)");
            Console.WriteLine("9 - Solicitar Reserva de Livro");
            Console.WriteLine("10 - Atender Próxima Reserva");
            Console.WriteLine("11 - Listar Livros na Pilha de Devoluções");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    Ordenacao.BubbleSortPorTitulo(biblioteca.Acervo, biblioteca.TotalLivros);
                    for (int i = 0; i < biblioteca.TotalLivros; i++)
                    {
                        Console.WriteLine(biblioteca.Acervo[i].Titulo + " (ID: " + biblioteca.Acervo[i].Id + " | Ano: " + biblioteca.Acervo[i].Ano + ")");
                    }
                    break;

                case 2:
                    Ordenacao.QuickSortPorAno(biblioteca.Acervo, 0, biblioteca.TotalLivros - 1);
                    for (int i = 0; i < biblioteca.TotalLivros; i++)
                    {
                        Console.WriteLine(biblioteca.Acervo[i].Ano + " - " + biblioteca.Acervo[i].Titulo);
                    }
                    break;

                case 3:
                    Console.Write("Digite o título exato do livro: ");
                    string tituloBusca = Console.ReadLine();
                    int posLinear = Busca.BuscaLinearPorTitulo(biblioteca.Acervo, biblioteca.TotalLivros, tituloBusca);

                    if (posLinear != -1)
                    {
                        Console.WriteLine("Encontrado: ID " + biblioteca.Acervo[posLinear].Id + " - " + biblioteca.Acervo[posLinear].Titulo);
                    }
                    else
                    {
                        Console.WriteLine("Livro não encontrado.");
                    }
                    break;

                case 4:
                    Ordenacao.BubbleSortPorId(biblioteca.Acervo, biblioteca.TotalLivros);
                    Console.Write("Digite o código (ID) do livro: ");
                    int idBusca = int.Parse(Console.ReadLine());
                    int posBinaria = Busca.BuscaBinariaPorId(biblioteca.Acervo, biblioteca.TotalLivros, idBusca);

                    if (posBinaria != -1)
                    {
                        Console.WriteLine("Encontrado: " + biblioteca.Acervo[posBinaria].Titulo + " | Disponíveis: " + biblioteca.Acervo[posBinaria].QuantidadeDisponivel);
                    }
                    else
                    {
                        Console.WriteLine("Livro não encontrado.");
                    }
                    break;

                case 5:
                    Console.Write("Digite a categoria (Terror, Ficção, Tecnologia, Romance, História): ");
                    string categoria = Console.ReadLine();
                    Livro[] porCategoria = Selecao.SelecionarPorCategoria(biblioteca.Acervo, biblioteca.TotalLivros, categoria);

                    Console.WriteLine("Total encontrados: " + porCategoria.Length);
                    for (int i = 0; i < porCategoria.Length; i++)
                    {
                        Console.WriteLine(porCategoria[i].Id + " - " + porCategoria[i].Titulo + " (" + porCategoria[i].Categoria + ")");
                    }
                    break;

                case 6:
                    Console.Write("Digite o ano inicial: ");
                    int anoMin = int.Parse(Console.ReadLine());
                    Console.Write("Digite o ano final: ");
                    int anoMax = int.Parse(Console.ReadLine());
                    Livro[] porAno = Selecao.SelecionarPorFaixaDeAno(biblioteca.Acervo, biblioteca.TotalLivros, anoMin, anoMax);

                    Console.WriteLine("Total encontrados: " + porAno.Length);
                    for (int i = 0; i < porAno.Length; i++)
                    {
                        Console.WriteLine(porAno[i].Ano + " - " + porAno[i].Titulo);
                    }
                    break;

                case 7:
                    Ordenacao.BubbleSortPorId(biblioteca.Acervo, biblioteca.TotalLivros);
                    Console.Write("Digite o código (ID) do livro devolvido: ");
                    int idDevolucao = int.Parse(Console.ReadLine());
                    int posDev = Busca.BuscaBinariaPorId(biblioteca.Acervo, biblioteca.TotalLivros, idDevolucao);

                    if (posDev != -1)
                    {
                        biblioteca.Acervo[posDev].QuantidadeDisponivel = biblioteca.Acervo[posDev].QuantidadeDisponivel + 1;
                        biblioteca.Pilha.Empilhar(biblioteca.Acervo[posDev]);
                        Console.WriteLine("Devolução registrada: " + biblioteca.Acervo[posDev].Titulo);
                    }
                    else
                    {
                        Console.WriteLine("Código inválido.");
                    }
                    break;

                case 8:
                    Livro conferido = biblioteca.Pilha.Desempilhar();
                    if (conferido != null)
                    {
                        Console.WriteLine("Livro conferido para guarda: " + conferido.Titulo);
                    }
                    else
                    {
                        Console.WriteLine("Não há livros aguardando conferência.");
                    }
                    break;

                case 9:
                    Ordenacao.BubbleSortPorId(biblioteca.Acervo, biblioteca.TotalLivros);
                    Console.Write("Nome do solicitante: ");
                    string nomeAluno = Console.ReadLine();
                    Console.Write("Código (ID) do livro para reserva: ");
                    int idReserva = int.Parse(Console.ReadLine());
                    int posRes = Busca.BuscaBinariaPorId(biblioteca.Acervo, biblioteca.TotalLivros, idReserva);

                    if (posRes != -1)
                    {
                        PedidoReserva pedido = new PedidoReserva(nomeAluno, biblioteca.Acervo[posRes].Id, biblioteca.Acervo[posRes].Titulo);
                        biblioteca.Fila.Enfileirar(pedido);
                        Console.WriteLine("Reserva registrada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Código inválido.");
                    }
                    break;

                case 10:
                    PedidoReserva atendido = biblioteca.Fila.Desenfileirar();
                    if (atendido != null)
                    {
                        Console.WriteLine("Reserva atendida: " + atendido.NomeUsuario + " -> " + atendido.TituloLivro);
                    }
                    else
                    {
                        Console.WriteLine("Não há reservas pendentes.");
                    }
                    break;

                case 11:
                    Livro[] empilhados = biblioteca.Pilha.ListarElementos();
                    if (empilhados.Length == 0)
                    {
                        Console.WriteLine("A pilha de devoluções está vazia.");
                    }
                    else
                    {
                        Console.WriteLine("=== LIVROS AGUARDANDO CONFERÊNCIA (TOPO -> BASE) ===");
                        for (int i = 0; i < empilhados.Length; i++)
                        {
                            Console.WriteLine((i + 1) + "º - ID " + empilhados[i].Id + ": " + empilhados[i].Titulo);
                        }
                    }
                    break;

                case 0:
                    Console.WriteLine("Encerrando o sistema...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }
    }
}
