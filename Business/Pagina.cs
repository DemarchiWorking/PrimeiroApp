using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Paginas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }

        public List<Paginas> Lista()
        {
            var lista = new List<Paginas>();
            var paginasDb = new Database.Paginas();
            foreach (DataRow row in paginasDb.Lista().Rows)
            {
                var pagina = new Paginas();
                pagina.Id = Convert.ToInt32(row["id"]);
                pagina.Nome = row["nome"].ToString();
                pagina.Conteudo = row["conteudo"].ToString();
                pagina.Data = Convert.ToDateTime(row["data"]);

                lista.Add(pagina);

            }
            return lista;
        }
    }
}