public class Pedido
{
    public static int id = 0;
    public List<Pizza> listaPizza;
    public Cliente cliente;
    public List<Extras> listaExtras;
    public double valorPago{get; set;}
    public bool pago = false;

    public Pedido(List<Pizza> listaPizza, List<Extras> listaExtras, Cliente cliente){
        this.listaPizza = listaPizza;
        this.listaExtras = listaExtras;
        this.cliente = cliente;

        id++;
    }

    public double ValorTotal()
    {
        double totalPizza = 0;
        
        for (int i = 0; i < listaPizza.Count; i++)
        {
            totalPizza += listaPizza[i].valor;
        }

        double totalExtras = 0;
        
        for (int i = 0; i < listaExtras.Count; i++)
        {
            totalExtras += listaExtras[i].valor;
        }


        return totalPizza + totalExtras;
    }

    public double ValorPago(){
        return this.ValorTotal() - this.valorPago;
    }
    
    public void ToString(){

        Console.WriteLine("Número do Pedido: " + id);

        Console.WriteLine("Pizzas: ");
        for (int i = 0; i < listaPizza.Count; i++)
        {
            Console.WriteLine(this.listaPizza[i].ToString());
        }

        string whiteSpace = "==================================";
        Console.WriteLine(whiteSpace);

        Console.WriteLine("Extras: ");
        for (int i = 0; i < listaExtras.Count; i++)
        {
            Console.WriteLine(this.listaExtras[i].ToString());
        }
        
        Console.WriteLine("Cliente: " + this.cliente.nome);
        Console.WriteLine("\nValor total: R$ " + this.ValorTotal());
        string status = pago == true ? "PAGO" : "NÃO PAGO";
        Console.WriteLine("\nStatus do pedido: " + status);
    }
}