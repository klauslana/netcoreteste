using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebCore.Models
{
    public class ModelMenuSistema
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public bool Agrupador { get; set; }
        public bool SouPai { get; set; }
        public int MeuPai { get; set; }
        public string Link { get; set; }
        public string ClasseIcone { get; set; }
        public int IDAplicativo { get; set; }
        public int IDPaginaAplicativo { get; set; }
        public int Ordem { get; set; }
    }
}
