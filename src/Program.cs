using System.Globalization;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {

      bool condicao = true;
      while (condicao)
      {
        Console.WriteLine("==================================");
        Console.WriteLine("======= SISTEMA DE PEDIDOS =======");
        Console.WriteLine("==================================");
        Console.WriteLine("Nome do cliente: ");
        string nome = Console.ReadLine();
        Cliente cliente = new Cliente(nome);
        
        var listaPizza = AskingForPizza();
        var listaExtras = AskingForExtras();
        var pedido = new Pedido(listaPizza, listaExtras, cliente);
        pagarPedido(pedido);
        pedido.ToString();
        Console.WriteLine("Anotar mais pedidos s/n");
        var confirma = Console.ReadLine();

        if (confirma == "n")
        {
            break;
        }
      }
    }
    public static List<Pizza> AskingForPizza()
    {
        List<Pizza> listaPizza = new List<Pizza>();
        bool condicao = true;

        while (condicao)
        {
            var pizza = new Pizza();

            Console.WriteLine("Sabor: ");
            pizza.sabor = Console.ReadLine();
            Console.WriteLine("  ");

            Console.WriteLine("Tamanho: ");
            pizza.tamanho = Console.ReadLine();
            Console.WriteLine("  ");

            Console.WriteLine("Preço: ");
            pizza.valor = double.Parse(Console.ReadLine());
            Console.WriteLine("  ");

            listaPizza.Add(pizza);

            Console.WriteLine("Deseja outra pizza? s/n");
            var confirma = Console.ReadLine();

            if (confirma == "n")
            {

                break;
            }
        }

        return listaPizza;
    }

    public static List<Extras> AskingForExtras()
    {
      List<Extras> listaExtras = new List<Extras>();
      bool condicao = true;
      while (condicao)
        {
            var extras = new Extras();

            Console.WriteLine("Gostaria de adicionar algum extra? s/n");
            var confirma = Console.ReadLine();

            if (confirma == "n")
            {
              Console.WriteLine("Nenhum extra adicionado");
              break;
            }

            Console.WriteLine("Qual extra deseja?");
            extras.extra = Console.ReadLine();
            Console.WriteLine("  ");

            Console.WriteLine("Descrição:");
            extras.descricao = Console.ReadLine();
            Console.WriteLine("  ");

            Console.WriteLine("Valor:");
            extras.valor = double.Parse(Console.ReadLine());
            Console.WriteLine("  ");

            listaExtras.Add(extras);

            Console.WriteLine("Deseja outro extra? s/n");
            confirma = Console.ReadLine();

            if (confirma == "n")
            {

                break;
            }
        }

        return listaExtras;
    }

    private static void pagarPedido(Pedido pedido)
    {
      Console.WriteLine("Valor total: " + pedido.ValorTotal());
      Console.WriteLine("\nDeseja pagar ou dar uma entrada? s/n");
      var resposta = Console.ReadLine();
      if (resposta == "s")
      {
        Console.WriteLine("Digite o valor: ");
        var value = Console.ReadLine();
        pedido.valorPago = double.Parse(value);
        if(pedido.ValorPago() == 0){
          pedido.pago = true;
        }
      }
    }
}