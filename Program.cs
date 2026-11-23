class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca(100);
        Menu menu = new Menu(biblioteca);
        menu.Exibir();
    }
}
