using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dojo.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public Faixa Faixa { get; set; }
        public TipoDeAssociacao TipoDeAssociacao { get; set; }
        public String Nome { get; set; }
        public String CPF { get; set; }

    }
}