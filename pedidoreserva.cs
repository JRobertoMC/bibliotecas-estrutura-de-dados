public class PedidoReserva
{
    public string NomeUsuario { get; set; }
    public int IdLivro { get; set; }
    public string TituloLivro { get; set; }

    public PedidoReserva(string nomeUsuario, int idLivro, string tituloLivro)
    {
        NomeUsuario = nomeUsuario;
        IdLivro = idLivro;
        TituloLivro = tituloLivro;
    }
}
