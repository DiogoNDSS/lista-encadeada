public class Lista
{
  public No inicio;
  public No fim;

  public Lista()
  {
    this.inicio = null;
    this.fim = null;
  }

  public void inserirInicio(int value)
  {
    No novoNo = new No(value);

    if (this.inicio == null && this.fim == null)
    {
      this.inicio = novoNo;
      this.fim = novoNo;
      System.Console.WriteLine("Insira a posição: " + this.inicio.valor);
    }
    else if (this.inicio != null && value < this.inicio.valor)
    {
      novoNo.noProx = this.inicio;
      this.inicio = novoNo;
      System.Console.WriteLine("Insira a posição: " + this.inicio.valor);
    }
    else
    {
      No noAtual = this.inicio;
      while (noAtual.noProx != null && value >= noAtual.noProx.valor)
      {
        noAtual = noAtual.noProx;
      }
      novoNo.noProx = noAtual.noProx;
      noAtual.noProx = novoNo;
      if (novoNo.noProx == null)
      {
        this.fim = novoNo;
      }
      System.Console.WriteLine("Insira a posição: " + novoNo.valor);
    }
  }

  public void inserirFim(int value)
  {
    No no = new No(value);

    if (this.inicio == null && this.fim == null)
    {
      this.inicio = no;
      this.fim = no;
      System.Console.WriteLine("Insira a posição: " + this.fim.valor);
    }
    else if (value >= this.fim.valor)
    {
      this.fim.noProx = no;
      this.fim = no;
      System.Console.WriteLine("Insira a posição: " + this.fim.valor);
    }
    else
    {
      No noAtual = this.inicio;
      while (noAtual.noProx != null && value >= noAtual.noProx.valor)
      {
        noAtual = noAtual.noProx;
      }
      no.noProx = noAtual.noProx;
      noAtual.noProx = no;
      System.Console.WriteLine("Insira a posição: " + no.valor);
    }
  }

  public void removerInicio()
  {
    if (this.inicio == null && this.fim == null)
    {
      System.Console.WriteLine("lista");
    }
    else if (this.inicio != null)
    {
      System.Console.WriteLine("Remove a posição: " + this.inicio.valor);
      this.inicio = this.inicio.noProx;
    }
  }

  public void removerFim()
  {
    if (this.inicio == null && this.fim == null)
    {
      System.Console.WriteLine("lista");
    }
    else if (this.inicio != null)
    {
      No noAux = this.inicio;
      if (noAux.noProx == null)
      {
        System.Console.WriteLine("Remove a posição: " + noAux.valor);
        this.inicio = null;
        this.fim = null;
      }
      else
      {
        while (noAux.noProx != this.fim)
        {
          noAux = noAux.noProx;
        }
        System.Console.WriteLine("Remove a posição: " + noAux.noProx.valor);
        this.fim = noAux;
        noAux.noProx = null;
      }
    }
  }

  public bool consulta(int Valor, ref No noAtual, ref No noAnterior)
  {
    noAtual = this.inicio;
    noAnterior = null;

    while (noAtual != null)
    {
      if (noAtual.valor == Valor)
      {
        return true;
      }
      noAnterior = noAtual;
      noAtual = noAtual.noProx;
    }

    return false;
  }

  public void percurso()
  {
    No noAux = this.inicio;
    System.Console.Write("\n[ List: ");
    while (noAux != null)
    {
      Console.Write(noAux.valor);
      if (noAux.noProx != null)
      {
        Console.Write(" -> ");
      }
      noAux = noAux.noProx;
    }
    System.Console.Write(" ]\n\n");
  }
}
