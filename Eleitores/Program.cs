using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleitores
{
    class Program
    {
        static void Main(string[] args)
        {
            var regEleitor = new RegraEleitores();

            IDictionary<string, string> dicRua = new Dictionary<string, string>();
            dicRua.Add("1000", "Rua 1");
            dicRua.Add("2000", "Rua 2");
            dicRua.Add("3000", "Rua 3");
            dicRua.Add("4000", "Rua 4");
            dicRua.Add("5000", "Rua 5");
            dicRua.Add("6000", "Rua 6");
            dicRua.Add("7000", "Rua 7");

            List<Casa> lstCasa = new List<Casa>();

            Random random = new Random();
            

            foreach (string key in dicRua.Keys)
            {
                
                var rua = regEleitor.retornaRua(key);
                for(int i = 0; i < 5; i++)
                {
                    var cs = new Casa();
                    cs.rua = rua;
                    cs.numero = i + 1;
                    cs.totalEleitores = random.Next(5);
                    lstCasa.Add(cs);
                }
                
            }

            var lstMelhoresRuas = regEleitor.ConsultarMelhoresRuas(lstCasa);

        }
    }
}
