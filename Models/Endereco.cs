using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Endereco {
        public int Id { get; set; }
        public string Logradouro{ get; set; }
        public Bairro Bairro { get; set; }
        public string Cep { get; set; }
        public Cidade Cidade{ get; set; }

    }

}
