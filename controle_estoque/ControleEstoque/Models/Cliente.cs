using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleEstoque.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
            //[StringLength(10, ErrorMessage = "Name cannot be longer than 10 characters.")]
            public string Fone { get; set; }
        public string Cpf { get; set; }

    }
}