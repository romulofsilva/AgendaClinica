using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleitores
{
    public class RegraEleitores : IRegraEleitores
    {
        public List<Rua> ConsultarMelhoresRuas(List<Casa> lstCasa)
        {
            List<Rua> lstRua = new List<Rua>();

            var lstCasaDif = lstCasa.GroupBy(c => c.rua,(key, values) => new
            {
                Rua = key,
                totalEleitores = values.Sum(x => x.totalEleitores)
            }).ToList();

            lstCasaDif = lstCasaDif.OrderByDescending(x => x.totalEleitores).ToList();

            foreach(var cs in lstCasaDif)
            {
                Rua rs = new Rua();
                rs.Cep = cs.Rua.Cep;
                rs.Nome = cs.Rua.Nome;

                lstRua.Add(rs);
                
            }
            
            return lstRua;
        }

        public Rua retornaRua(string cep)
        {
            IDictionary<string, string> dicRua = new Dictionary<string, string>();
            dicRua.Add("1000", "Rua 1");
            dicRua.Add("2000", "Rua 2");
            dicRua.Add("3000", "Rua 3");
            dicRua.Add("4000", "Rua 4");
            dicRua.Add("5000", "Rua 5");
            dicRua.Add("6000", "Rua 6");
            dicRua.Add("7000", "Rua 7");


            var rua = new Rua()
                            {Cep = cep,
                            Nome= dicRua[cep]
            };

            return rua;
        }

       
    }

    public interface IRegraEleitores
    {
        List<Rua> ConsultarMelhoresRuas(List<Casa> lstCasas);

        Rua retornaRua(string cep);

    }
}
