using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    [Table("tblCidade")]
    public class Cidade
    {
        private Guid ukey;
        private string nomeCidade;
        private string codigoIbge;
        private Guid idEstado;
        private Estado estado;

        [Key]
        public Guid Ukey { get => ukey; set => ukey = value; }

        [Column(TypeName ="nvarchar")]
        [Required(ErrorMessage ="O nome da cidade é obrigatório!")]
        [StringLength(100)]
        public string NomeCidade { get => nomeCidade; set => nomeCidade = value; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "O código IBGE da cidade é obrigatório!")]
        [StringLength(10)]
        public string CodigoIbge { get => codigoIbge; set => codigoIbge = value; }

        [ForeignKey("Estado")]
        public Guid IdEstado { get => idEstado; set => idEstado = value; }
        public Estado Estado { get => estado; set => estado = value; }

        public ICollection<Cep> cep { get; set; }
    }
}
