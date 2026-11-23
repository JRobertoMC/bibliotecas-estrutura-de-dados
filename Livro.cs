public class Livro
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
    public string Categoria { get; set; }
    public int QuantidadeTotal { get; set; }
    public int QuantidadeDisponivel { get; set; }

    public Livro(int id, string titulo, string autor, int ano, string categoria, int quantidadeTotal)
    {
        Id = id;
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
        Categoria = categoria;
        QuantidadeTotal = quantidadeTotal;
        QuantidadeDisponivel = quantidadeTotal;
    }

    public bool EstaDisponivel()
    {
        if (QuantidadeDisponivel > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
