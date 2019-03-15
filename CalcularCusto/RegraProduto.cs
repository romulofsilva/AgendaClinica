using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularCusto
{
    public class RegraProduto : IRegraProduto
    {
        public Produto RetornaProduto(int Id)
        {
            try
            {
                var prod = new Produto()
                {
                    Id = Id,
                    Nome = "Danone",
                    Custo = 2.5,
                    isRefrigerado = true,
                    isRiscoExpirar = false,
                    Volume = 0.5,
                    Validade = 30
                };

                return prod;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Produto RetornaProdutoNome(string Nome)
        {
            try
            {
                var prod = new Produto()
                {
                    Id = 1,
                    Nome = Nome,
                    Custo = 3.5,
                    isRefrigerado = true,
                    isRiscoExpirar = false,
                    Volume = 1.5,
                    Validade = 30
                };

                return prod;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public double CalcularCusto(Produto prod)
        {
            
            try
            {
                if (prod != null)
                {
                    if(prod.isRefrigerado && prod.isRiscoExpirar == false && prod.Volume > 0.5)
                    {
                        prod.Custo = prod.Custo + (prod.Custo * 0.3);
                    }
                    else if(prod.isRefrigerado && prod.isRiscoExpirar == false && prod.Volume < 0.5)
                    {
                        prod.Custo = prod.Custo + (prod.Custo * 0.2);
                    }
                    
                    else if(prod.isRefrigerado == false && prod.isRiscoExpirar==false && prod.Volume > 0.5)
                    {
                        prod.Custo = prod.Custo + (prod.Custo * 0.1);
                    }
                    else if (prod.isRefrigerado == false && prod.isRiscoExpirar == false && prod.Volume < 0.5)
                    {
                        prod.Custo = prod.Custo + 0.5; 
                    }

                    if(prod.isRiscoExpirar == true)
                    {
                        prod.Custo = prod.Custo - (prod.Custo * 0.4);
                    }
                }

                return prod.Custo;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    public interface IRegraProduto
    {
        Produto RetornaProduto(int Id);
        Produto RetornaProdutoNome(string nomeProd);
        double CalcularCusto(Produto Prod);
    }
}
