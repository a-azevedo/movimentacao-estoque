
List<Produtos> estoqueDeProdutos = new List<Produtos>();
var itensParaAdicionar = new List<Produtos>();
int cod = 0;
int tipoOperacao = 0;
int quantidade = 0;
int opcao = 0;


Produtos produto1 = new Produtos(1,"bola",50);
Produtos produto2 = new Produtos(2,"bola",30);
Produtos produto3 = new Produtos(3,"bola",150);
Produtos produto4 = new Produtos(4,"bola",90);
Produtos produto5 = new Produtos(5,"bola",40);

estoqueDeProdutos.Add(produto1);
estoqueDeProdutos.Add(produto2);
estoqueDeProdutos.Add(produto3);
estoqueDeProdutos.Add(produto4);
estoqueDeProdutos.Add(produto5);


Console.WriteLine("Digite o código do produto");
cod = Convert.ToInt32(Console.ReadLine());

foreach(Produtos p in estoqueDeProdutos){
    //Console.WriteLine($"Cod:{p.cod}, Nome:{p.nome}, Quantidade:{p.quantidade}");

    if(cod == p.cod){
        Console.WriteLine($"Cod:{p.cod}, Nome:{p.nome}, Quantidade:{p.quantidade}");
        Console.WriteLine("Digite 1 para entrada de produtos e 0 para saída");
        tipoOperacao = Convert.ToInt32(Console.ReadLine());
        if(tipoOperacao == 1){
            Console.WriteLine($"Digite a quantidade para adicionar");            
            quantidade = Convert.ToInt32(Console.ReadLine());            
            p.quantidade += quantidade;
        }else if(tipoOperacao == 0){
            Console.WriteLine($"Digite a quantidade para subtrair");
            quantidade = Convert.ToInt32(Console.ReadLine());
            if(quantidade <= p.quantidade){
            p.quantidade -= quantidade;
            }else{
                Console.WriteLine($"Quantidade insuficiente em estoque. Saldo em estoque é de: {p.quantidade}");
            }
        }
    Console.WriteLine($"Cod:{p.cod}, Nome:{p.nome}, Quantidade:{p.quantidade}");
    }else{
        Console.WriteLine($"Produto fora de estoque. Deseja incluir 1 - Sim | 0 - Não");
        opcao = Convert.ToInt32(Console.ReadLine());
        if(opcao == 1){
        Produtos novoProduto = new Produtos(cod,Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            itensParaAdicionar.Add(novoProduto);
        }
    }
}
            estoqueDeProdutos.AddRange(itensParaAdicionar);



