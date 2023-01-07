// See https://aka.ms/new-console-template for more information
internal class Produtos
{
    public int cod { get; set; }
    public string nome { get; set; }
    public int quantidade { get; set; }

    public Produtos(){

    }
    public Produtos(int cod, string nome, int quantidade){
        this.cod = cod;
        this.nome = nome;
        this.quantidade = quantidade;
    }
}