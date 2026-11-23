public class Biblioteca
{
    public Livro[] Acervo { get; set; }
    public int TotalLivros { get; set; }
    public PilhaDevolucoes Pilha { get; set; }
    public FilaEspera Fila { get; set; }

    public Biblioteca(int capacidadeAcervo)
    {
        TotalLivros = capacidadeAcervo;
        Acervo = new Livro[TotalLivros];
        Pilha = new PilhaDevolucoes(50);
        Fila = new FilaEspera(50);

        PreencherAcervoInicial();
    }

    private void PreencherAcervoInicial()
    {
        Acervo[0] = new Livro(1, "Dom Casmurro", "Machado de Assis", 1899, "Romance", 4);
        Acervo[1] = new Livro(2, "It: A Coisa", "Stephen King", 1986, "Terror", 2);
        Acervo[2] = new Livro(3, "Código Limpo", "Robert C. Martin", 2008, "Tecnologia", 5);
        Acervo[3] = new Livro(4, "1984", "George Orwell", 1949, "Ficção", 3);
        Acervo[4] = new Livro(5, "Sapiens", "Yuval Noah Harari", 2011, "História", 6);
        Acervo[5] = new Livro(6, "O Iluminado", "Stephen King", 1977, "Terror", 2);
        Acervo[6] = new Livro(7, "Memórias Póstumas de Brás Cubas", "Machado de Assis", 1881, "Romance", 3);
        Acervo[7] = new Livro(8, "O Programador Pragmático", "Andrew Hunt", 1999, "Tecnologia", 4);
        Acervo[8] = new Livro(9, "Duna", "Frank Herbert", 1965, "Ficção", 3);
        Acervo[9] = new Livro(10, "A Segunda Guerra Mundial", "Antony Beevor", 2012, "História", 2);

        Acervo[10] = new Livro(11, "Drácula", "Bram Stoker", 1897, "Terror", 3);
        Acervo[11] = new Livro(12, "Orgulho e Preconceito", "Jane Austen", 1813, "Romance", 5);
        Acervo[12] = new Livro(13, "Algoritmos: Teoria e Prática", "Thomas Cormen", 2009, "Tecnologia", 2);
        Acervo[13] = new Livro(14, "Admirável Mundo Novo", "Aldous Huxley", 1932, "Ficção", 4);
        Acervo[14] = new Livro(15, "1808", "Laurentino Gomes", 2007, "História", 3);
        Acervo[15] = new Livro(16, "Frankenstein", "Mary Shelley", 1818, "Terror", 2);
        Acervo[16] = new Livro(17, "A Hora da Estrela", "Clarice Lispector", 1977, "Romance", 4);
        Acervo[17] = new Livro(18, "Arquitetura Limpa", "Robert C. Martin", 2017, "Tecnologia", 3);
        Acervo[18] = new Livro(19, "Fundação", "Isaac Asimov", 1951, "Ficção", 5);
        Acervo[19] = new Livro(20, "1822", "Laurentino Gomes", 2010, "História", 2);

        Acervo[20] = new Livro(21, "O Chamado de Cthulhu", "H.P. Lovecraft", 1928, "Terror", 1);
        Acervo[21] = new Livro(22, "Capitães da Areia", "Jorge Amado", 1937, "Romance", 4);
        Acervo[22] = new Livro(23, "Estruturas de Dados e Algoritmos", "Narasimha Karumanchi", 2016, "Tecnologia", 3);
        Acervo[23] = new Livro(24, "Fahrenheit 451", "Ray Bradbury", 1953, "Ficção", 2);
        Acervo[24] = new Livro(25, "1889", "Laurentino Gomes", 2013, "História", 3);
        Acervo[25] = new Livro(26, "Cemitério Maldito", "Stephen King", 1983, "Terror", 2);
        Acervo[26] = new Livro(27, "Grande Sertão: Veredas", "Guimarães Rosa", 1956, "Romance", 2);
        Acervo[27] = new Livro(28, "Use a Cabeça! C#", "Andrew Stellman", 2021, "Tecnologia", 6);
        Acervo[28] = new Livro(29, "Eu, Robô", "Isaac Asimov", 1950, "Ficção", 4);
        Acervo[29] = new Livro(30, "Raízes do Brasil", "Sérgio Buarque de Holanda", 1936, "História", 3);

        Acervo[30] = new Livro(31, "O Exorcista", "William Peter Blatty", 1971, "Terror", 1);
        Acervo[31] = new Livro(32, "O Cortiço", "Aluísio Azevedo", 1890, "Romance", 5);
        Acervo[32] = new Livro(33, "Padrões de Projetos", "Erich Gamma", 1994, "Tecnologia", 2);
        Acervo[33] = new Livro(34, "Neuromancer", "William Gibson", 1984, "Ficção", 3);
        Acervo[34] = new Livro(35, "Casa-Grande & Senzala", "Gilberto Freyre", 1933, "História", 2);
        Acervo[35] = new Livro(36, "Carrie, a Estranha", "Stephen King", 1974, "Terror", 3);
        Acervo[36] = new Livro(37, "Iracema", "José de Alencar", 1865, "Romance", 4);
        Acervo[37] = new Livro(38, "Refatoração", "Martin Fowler", 1999, "Tecnologia", 2);
        Acervo[38] = new Livro(39, "O Fim da Eternidade", "Isaac Asimov", 1955, "Ficção", 3);
        Acervo[39] = new Livro(40, "Formação Econômica do Brasil", "Celso Furtado", 1959, "História", 2);

        Acervo[40] = new Livro(41, "A Assombração da Casa da Colina", "Shirley Jackson", 1959, "Terror", 2);
        Acervo[41] = new Livro(42, "O Guarani", "José de Alencar", 1857, "Romance", 3);
        Acervo[42] = new Livro(43, "Redes de Computadores", "Andrew Tanenbaum", 2011, "Tecnologia", 4);
        Acervo[43] = new Livro(44, "O Guia do Mochileiro das Galáxias", "Douglas Adams", 1979, "Ficção", 5);
        Acervo[44] = new Livro(45, "A Era dos Extremos", "Eric Hobsbawm", 1994, "História", 3);
        Acervo[45] = new Livro(46, "Misery", "Stephen King", 1987, "Terror", 2);
        Acervo[46] = new Livro(47, "Senhora", "José de Alencar", 1875, "Romance", 4);
        Acervo[47] = new Livro(48, "Sistemas Operacionais Modernos", "Andrew Tanenbaum", 2014, "Tecnologia", 3);
        Acervo[48] = new Livro(49, "O Senhor dos Anéis: A Sociedade do Anel", "J.R.R. Tolkien", 1954, "Ficção", 6);
        Acervo[49] = new Livro(50, "A Era das Revoluções", "Eric Hobsbawm", 1962, "História", 2);

        Acervo[50] = new Livro(51, "O Bebê de Rosemary", "Ira Levin", 1967, "Terror", 1);
        Acervo[51] = new Livro(52, "Vidas Secas", "Graciliano Ramos", 1938, "Romance", 5);
        Acervo[52] = new Livro(53, "Engenharia de Software", "Ian Sommerville", 2011, "Tecnologia", 4);
        Acervo[53] = new Livro(54, "O Hobbit", "J.R.R. Tolkien", 1937, "Ficção", 5);
        Acervo[54] = new Livro(55, "A Era do Capital", "Eric Hobsbawm", 1975, "História", 2);
        Acervo[55] = new Livro(56, "Salem", "Stephen King", 1975, "Terror", 2);
        Acervo[56] = new Livro(57, "São Bernardo", "Graciliano Ramos", 1934, "Romance", 3);
        Acervo[57] = new Livro(58, "Sistemas de Banco de Dados", "Abraham Silberschatz", 2010, "Tecnologia", 3);
        Acervo[58] = new Livro(59, "O Problema dos Três Corpos", "Cixin Liu", 2008, "Ficção", 4);
        Acervo[59] = new Livro(60, "A Era dos Impérios", "Eric Hobsbawm", 1987, "História", 2);

        Acervo[60] = new Livro(61, "Entrevista com o Vampiro", "Anne Rice", 1976, "Terror", 3);
        Acervo[61] = new Livro(62, "Quincas Borba", "Machado de Assis", 1891, "Romance", 4);
        Acervo[62] = new Livro(63, "Entendendo Algoritmos", "Aditya Bhargava", 2016, "Tecnologia", 7);
        Acervo[63] = new Livro(64, "A Floresta Sombria", "Cixin Liu", 2008, "Ficção", 3);
        Acervo[64] = new Livro(65, "Homo Deus", "Yuval Noah Harari", 2015, "História", 4);
        Acervo[65] = new Livro(66, "O Colecionador", "John Fowles", 1963, "Terror", 2);
        Acervo[66] = new Livro(67, "Esaú e Jacó", "Machado de Assis", 1904, "Romance", 2);
        Acervo[67] = new Livro(68, "Introdução à Programação com Python", "Nilo Ney", 2019, "Tecnologia", 5);
        Acervo[68] = new Livro(69, "O Fim da Morte", "Cixin Liu", 2010, "Ficção", 3);
        Acervo[69] = new Livro(70, "21 Lições para o Século 21", "Yuval Noah Harari", 2018, "História", 4);

        Acervo[70] = new Livro(71, "Coraline", "Neil Gaiman", 2002, "Terror", 4);
        Acervo[71] = new Livro(72, "O Primo Basílio", "Eça de Queirós", 1878, "Romance", 3);
        Acervo[72] = new Livro(73, "Domain-Driven Design", "Eric Evans", 2003, "Tecnologia", 2);
        Acervo[73] = new Livro(74, "Deuses Americanos", "Neil Gaiman", 2001, "Ficção", 3);
        Acervo[74] = new Livro(75, "Armas, Germes e Aço", "Jared Diamond", 1997, "História", 3);
        Acervo[75] = new Livro(76, "O Silêncio dos Inocentes", "Thomas Harris", 1988, "Terror", 2);
        Acervo[76] = new Livro(77, "Os Maias", "Eça de Queirós", 1888, "Romance", 2);
        Acervo[77] = new Livro(78, "C# em Profundidade", "Jon Skeet", 2019, "Tecnologia", 3);
        Acervo[78] = new Livro(79, "Solaris", "Stanislaw Lem", 1961, "Ficção", 2);
        Acervo[79] = new Livro(80, "Colapso", "Jared Diamond", 2005, "História", 2);

        Acervo[80] = new Livro(81, "Dragão Vermelho", "Thomas Harris", 1981, "Terror", 2);
        Acervo[81] = new Livro(82, "O Morro dos Ventos Uivantes", "Emily Brontë", 1847, "Romance", 4);
        Acervo[82] = new Livro(83, "A Arte da Programação de Computadores", "Donald Knuth", 1968, "Tecnologia", 1);
        Acervo[83] = new Livro(84, "Laranja Mecânica", "Anthony Burgess", 1962, "Ficção", 3);
        Acervo[84] = new Livro(85, "O Povo Brasileiro", "Darcy Ribeiro", 1995, "História", 3);
        Acervo[85] = new Livro(86, "Psicose", "Robert Bloch", 1959, "Terror", 2);
        Acervo[86] = new Livro(87, "Jane Eyre", "Charlotte Brontë", 1847, "Romance", 3);
        Acervo[87] = new Livro(88, "Compiladores: Princípios, Técnicas e Ferramentas", "Alfred Aho", 2006, "Tecnologia", 2);
        Acervo[88] = new Livro(89, "O Homem do Castelo Alto", "Philip K. Dick", 1962, "Ficção", 3);
        Acervo[89] = new Livro(90, "História do Brasil", "Boris Fausto", 1994, "História", 4);

        Acervo[90] = new Livro(91, "A Coisa na Soleira da Porta", "H.P. Lovecraft", 1937, "Terror", 1);
        Acervo[91] = new Livro(92, "Anna Kariênina", "Liev Tolstói", 1877, "Romance", 2);
        Acervo[92] = new Livro(93, "Arquitetura de Computadores", "David Patterson", 2013, "Tecnologia", 3);
        Acervo[93] = new Livro(94, "Androides Sonham com Ovelhas Elétricas?", "Philip K. Dick", 1968, "Ficção", 4);
        Acervo[94] = new Livro(95, "Brasil: Uma Biografia", "Lilia Schwarcz", 2015, "História", 4);
        Acervo[95] = new Livro(96, "O Médico e o Monstro", "Robert Louis Stevenson", 1886, "Terror", 3);
        Acervo[96] = new Livro(97, "Crime e Castigo", "Fiódor Dostoiévski", 1866, "Romance", 3);
        Acervo[97] = new Livro(98, "Segurança de Redes", "William Stallings", 2017, "Tecnologia", 2);
        Acervo[98] = new Livro(99, "A Mão Esquerda da Escuridão", "Ursula K. Le Guin", 1969, "Ficção", 2);
        Acervo[99] = new Livro (100,"A cadeiruda","Desconhecido",2026,"Terror",2);
    }
}