using System.Globalization;

namespace ProjetoProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            
            Console.WriteLine("Entre os dados do produto:");
            Console.WriteLine("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preco: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Dados do Produto: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a adicionar do estoque: ");
            int qte = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: "+ produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a remover do estoque: ");
            qte = int.Parse(Console.ReadLine());

            produto.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: "+ produto);
        }
    }
}
