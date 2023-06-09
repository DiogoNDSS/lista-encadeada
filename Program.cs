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

      System.Console.WriteLine("-");
      System.Console.WriteLine("-");
      System.Console.WriteLine("-");
      //  exercício 2

      Funcionario lista2 = new Funcionario();
      lista2.inserirInicio("Joao paulo", 18, "1111111111", 1500.0);
      lista2.inserirInicio("Yan Andrade", 19, "2222222222", 50000.00);
      lista2.inserirInicio("Claudiao", 18, "3333333333", 1500.00);
      lista2.inserirFim("Joao", 17, "4444444444", 500.0);
      lista2.inserirFim("Diogo", 18, "5555555555", 50000.0);

      lista2.percurso();
      lista2.consultaNome("Diogo", lista2);

      lista2.removerFim();
      lista2.removerInicio();
      lista2.percurso();

      lista2.impressao();

      System.Console.WriteLine("-");
      System.Console.WriteLine("-");
      System.Console.WriteLine("-");
      //  exercício 3

      ListaAssunto lista3 = new ListaAssunto();

      lista3.inserirInicio("Lenhador", 6, 24, "Rafael");
      lista3.inserirInicio("Barbeiro", 6, 48, "Diogo");
      lista3.inserirInicio("Professor", 6, 40, "Bruno");
      lista3.inserirInicio("Programador", 6, 48, "Yan");
      lista3.inserirInicio("Instrutor", 6, 24, "Kayk");
      lista3.impressao();
      lista3.consultaNome("Lenhador", lista3);





    }
  }
}