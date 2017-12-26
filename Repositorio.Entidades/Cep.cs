using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    [Table("tblCep")]
    public class Cep
    {
        private Guid ukey;
        private string cepe;
        private Guid idCidade;
        private Cidade cidade;

        [Key]
        public Guid Ukey { get => ukey; set => ukey = value; }

        [Column(TypeName ="nvarchar")]
        [Required(ErrorMessage ="Cep é obrigatório")]
        [StringLength(8)]
        public string Cepe { get => cepe; set => cepe = value; }

        [ForeignKey("Cidade")]
        public Guid IdCidade { get => idCidade; set => idCidade = value; }
        public Cidade Cidade { get => cidade; set => cidade = value; }
        
    }
}
