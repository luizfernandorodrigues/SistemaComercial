using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao
{
    public class CEPAbertoResponse
    {
        public Decimal? altitude { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public decimal? latitude { get; set; }
        public decimal? longitude { get; set; }
        public string cidade { get; set; }
        public short? ddd { get; set; }
        public int? ibge { get; set; }
        public string estado { get; set; }
        public string estado_sigla { get; set; }
        public string status { get; set; }
    }
}
