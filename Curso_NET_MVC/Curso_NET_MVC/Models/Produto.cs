using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_NET_MVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        [Display(Name = "Descrição")]
        public String Descricao { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
