using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Repositorio.Entidades
{
    [Table("tblGrupoUsuario")]
    public class GrupoUsuario
    {
        private Guid ukey;
        private string codigoGrupo;
        private string nomeGrupo;

        [Key]
        public Guid Ukey { get => ukey; set => ukey = value; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Código do grupo é obrigatório")]
        [Display(Name = "Código")]
        [StringLength(10)]
        public string CodigoGrupo { get => codigoGrupo; set => codigoGrupo = value; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Nome do grupo é obrigatório")]
        [Display(Name = "Nome")]
        [StringLength(50)]
        public string NomeGrupo { get => nomeGrupo; set => nomeGrupo = value; }

        public ICollection<Usuario> usuario { get; set; }
    }
}
