public class Pizza
{
    public string sabor;
    public string tamanho;
    public double valor; 

    public string ToString(){
        string whiteSpace = "---------------------------------------------------------------";
        return whiteSpace + "\nSabor: " + this.sabor + "\nPreço: " + this.valor + "\nTamanho: " + this.tamanho + "\n" + whiteSpace;
    }
}