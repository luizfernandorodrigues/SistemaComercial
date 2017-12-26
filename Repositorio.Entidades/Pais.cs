using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    [Table("tblPais")]
    public class Pais
    {
        
        private Guid ukey;
        private string nome;
        private string codigo;

        [Key]
        public Guid Ukey { get => ukey; set => ukey = value; }

        [Column(TypeName ="nvarchar")]
        [MaxLength(50)]
        public string Nome { get => nome; set => nome = value; }

        [Column(TypeName ="nvarchar")]
        [MaxLength(4)]
        public string Codigo { get => codigo; set => codigo = value; }

        public ICollection<Estado> estado { get; set; }
    }
}
