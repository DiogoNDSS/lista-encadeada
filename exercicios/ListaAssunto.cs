public class ListaAssunto
{
  public NoAssunto inicio;
  public NoAssunto fim;

  public ListaAssunto()
  {
    this.inicio = null;
    this.fim = null;
  }

  public void inserirInicio(string nome, int periodo, int cargaHoraria, string professor)
  {
    NoAssunto novoNo = new NoAssunto(nome, periodo, cargaHoraria, professor);

    if (this.inicio == null && this.fim == null)
    {
      this.inicio = novoNo;
      this.fim = novoNo;
      System.Console.WriteLine("Insira na posição: " + this.inicio.nome);
    }
    else if (this.inicio != null)
    {
      novoNo.noProx = this.inicio;
      this.inicio = novoNo;
      System.Console.WriteLine("Insira na posição: " + this.inicio.nome);
    }
  }

  public void impressao()
  {

    NoAssunto noAux = this.inicio;
    System.Console.Write("List");
    while (noAux != null)
    {
      System.Console.WriteLine("\nNome: " + noAux.nome);
      System.Console.WriteLine("Período: " + noAux.periodo);
      System.Console.WriteLine("Carga Horaria: " + noAux.cargaHoraria);
      System.Console.WriteLine("Professor: " + noAux.professor);
      noAux = noAux.noProx;
    }
  }

  public Boolean consulta(string nome, ref NoAssunto noAtual, ref NoAssunto noAnterior)
  {

    noAtual = this.inicio;
    noAnterior = null;

    while (noAtual != null)
    {
      if (noAtual.nome == nome)
      { //SE ENCONTROU O VALOR
        return (true);
      }
      noAnterior = noAtual;
      noAtual = noAtual.noProx;
    }

    return (false);
  }

  public void consultaNome(string nome, ListaAssunto lista)
  {
    NoAssunto? noAtual = null;
    NoAssunto? noAnterior = null;

    Boolean encontrou = lista.consulta(nome, ref noAtual, ref noAnterior);
    if (encontrou)
    {
      Console.WriteLine("Encontrou o no de valor: " + noAtual.nome);
    }
    else
    {
      Console.WriteLine("Não encontrou o no procurado!");
    }
  }
}