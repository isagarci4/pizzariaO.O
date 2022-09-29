using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {


    List<Pizza> listaUsuarios = new List<Pizza>();
    bool condicao = true;

    while(condicao){
      var pizza = new Pizza();

      Console.WriteLine("Sabor: ");
      pizza.sabor = Console.ReadLine();
      Console.WriteLine("  ");

      Console.WriteLine("Tamanho: ");
      pizza.tamanho = Console.ReadLine();
      Console.WriteLine("  ");

      Console.WriteLine("Preço: ");
      pizza.preco = double.Parse(Console.ReadLine());
      Console.WriteLine("  ");

      listaUsuarios.Add(pizza);

      Console.WriteLine("Deseja Add mais? s/n");
      var confirma = Console.ReadLine();

      if(confirma == "n"){
        break;
      }
   }
   
    
    Console.WriteLine(listaUsuarios[0].preco);
  }
}