namespace lista
{

  class Program
  {
    static void Main(string[] args)
    {
      //exercício 1
      Lista lista = new();
      lista.inserirInicio(50);
      lista.inserirInicio(15);
      lista.inserirInicio(5);
      lista.inserirFim(20);

      lista.percurso();

      lista.removerInicio();
      lista.removerFim();

      lista.percurso();
      // fim do exercício 1
      System.Console.WriteLine("---");
      System.Console.WriteLine("---");
      System.Console.WriteLine("---");
      //  exercício 2

      Funcionario lista2 = new Funcionario();
      lista2.inserirInicio("João Pedro", 18, "3927382783", 1500.0);
      lista2.inserirInicio("Yan Andrade", 19, "263726377272", 50000.00);
      lista2.inserirInicio("Kayk", 18, "263726377272", 1500.00);
      lista2.inserirFim("Adryan", 17, "36262762672", 500.0);
      lista2.inserirFim("Diogo", 18, "4382738728738", 50000.0);

      lista2.percurso();
      lista2.consultaNome("Diogo", lista2);

      lista2.removerFim();
      lista2.removerInicio();
      lista2.percurso();

      lista2.impressao();
      // fim do exercício 2
      System.Console.WriteLine("---");
      System.Console.WriteLine("---");
      System.Console.WriteLine("---");
      //  exercício 3

      ListaAssunto lista3 = new ListaAssunto();

      lista3.inserirInicio("Engenheiro", 6, 24, "Gabiroba");
      lista3.inserirInicio("Pedreiro", 6, 48, "Adryan");
      lista3.inserirInicio("Professor", 6, 40, "Rafael");
      lista3.inserirInicio("Garipeiro", 6, 48, "Gabiroba");
      lista3.inserirInicio("Babá", 6, 24, "Kayk");
      lista3.impressao();
      lista3.consultaNome("Engenheiro", lista3);

      // fim do exercício 3



    }
  }
}