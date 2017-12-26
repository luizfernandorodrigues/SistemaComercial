using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    [Table("tblEstado")]
   public class Estado
    {
        private Guid ukey;
        private string nome;
        private string sigla;
        private Guid idPais;
        private Pais pais;

        [Key]
        public Guid Ukey { get => ukey; set => ukey = value; }

        [Column(TypeName ="nvarchar")]
        [MaxLength(50)]
        public string Nome { get => nome; set => nome = value; }

        [Column(TypeName ="nvarchar")]
        [MaxLength(2)]
        public string Sigla { get => sigla; set => sigla = value; }

        [ForeignKey("Pais")]
        public Guid IdPais { get => idPais; set => idPais = value; }
        
        public virtual Pais Pais { get => pais; set => pais = value; }
    }
}
