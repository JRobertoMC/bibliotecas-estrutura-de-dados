Projeto acadêmico desenvolvido para a disciplina de *Estruturas de Dados II* do curso de *Sistemas de Informação* do *Centro Universitário UNISAPIENS* (Porto Velho - RO, 2026).

---

## 📋 Sobre o Projeto

O sistema consiste em uma aplicação de console desenvolvida em *C#* para gerenciar um acervo inicial de *100 obras literárias. Para consolidar o aprendizado prático da disciplina, todas as estruturas de dados e algoritmos foram implementados **manualmente sobre vetores estáticos*, sem o uso de bibliotecas ou coleções prontas da linguagem.

---

## ⚙️ Estruturas de Dados e Algoritmos Implementados

* *Pilha (PilhaDevolucoes.cs):* Estrutura linear sob o princípio *LIFO* (Last In, First Out) utilizada na triagem e conferência de livros devolvidos.
* *Fila Circular (FilaEspera.cs):* Estrutura linear sob o princípio *FIFO* (First In, First Out) implementada sobre vetor circular para gerenciar a lista de espera de reservas.
* *Ordenação (Ordenacao.cs):*
  * *Bubble Sort:* Ordenação do acervo em ordem alfabética por *Título*.
  * *Quick Sort:* Ordenação eficiente do acervo por *Ano de Publicação*.
* *Busca (Busca.cs):*
  * *Busca Linear:* Localização de obras pelo *Título* exato.
  * *Busca Binária:* Localização rápida de obras pelo código *ID*.
* *Seleção Condicional (Selecao.cs):* Filtragem de subconjuntos do acervo por *Categoria* e por *Faixa de Ano*.

---

## 🗂️ Arquitetura do Sistema

O projeto está modularizado nas seguintes classes:

* Program.cs — Ponto de entrada da aplicação.
* Menu.cs — Interface interativa de console com as opções de operação.
* Biblioteca.cs — Gerencia o vetor principal do acervo (100 livros), a pilha de devoluções e a fila de espera.
* Livro.cs — Modelo de dados das obras literárias.
* PedidoReserva.cs — Modelo de dados das solicitações de reserva.
* PilhaDevolucoes.cs — Implementação manual da Pilha.
* FilaEspera.cs — Implementação manual da Fila Circular.
* Ordenacao.cs — Métodos Bubble Sort e Quick Sort.
* Busca.cs — Métodos de Busca Linear e Busca Binária.
* Selecao.cs — Métodos de filtragem condicional.

---

## 🚀 Como Executar

1. Clone este repositório:
   bash
   git clone https://github.com
   
2. Acesse a pasta do projeto pelo terminal ou abra no *Visual Studio Code*.
3. Execute a aplicação com o comando:
   bash
   dotnet run
   

---

## 👥 Integrantes do Grupo

* *Celso Ricardo Bastos Gonçalves Junior*
* *João Roberto Melo de Carvalho*
* *Renan Queiroz C. de Oliveira*
* *Yuri dos Santos Reis*

*Orientadora:* Prof.ª Rosângela
