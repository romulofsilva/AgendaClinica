using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularCusto
{
    class Program
    {
        static void Main(string[] args)
        {
            RegraProduto regraProduto = new RegraProduto();

            var prod = regraProduto.RetornaProduto(1);

            prod.Custo = regraProduto.CalcularCusto(prod);

            double preco=0;// = HiperMercado.DT.FormulaMagica(prod.Custo, prod.Validade);

            Console.WriteLine("O Preço de venda deste produto é de R$" + string.Format("{0:#.00}", preco));
        }
    }
}
