﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Endereco { 
         public int Id { get; set; }
        public string Lagradouro{ get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public Cidade cidade{ get; set; }


    }
}