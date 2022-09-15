public class Pizza
{
    public string sabor;
    public string tamanho;
    public int preco;

    public bool saborObrigatorio (string sabor)
    {
        if(sabor == null){
            return false;
        }else{
            return true;
        }
    }
}