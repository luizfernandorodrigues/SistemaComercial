using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    [Table("tblUsuario")]
    public class Usuario
    {
        private Guid ukey;
        private string login;
        private string senha;
        private string nomeUsuario;
        private string emailUsuario;
        private Decimal adm;
        private Guid idGrupo;
        private GrupoUsuario grupoUsuario;

        [Key]
        public Guid Ukey { get => ukey; set => ukey = value; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "login é obrigatório!")]
        [StringLength(50)]
        [Display(Name = "Login")]
        public string Login { get => login; set => login = value; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "senha é obrigatório!")]
        [StringLength(50)]
        [Display(Name = "Senha")]
        public string Senha { get => senha; set => senha = value; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "nome é obrigatório!")]
        [StringLength(50)]
        [Display(Name = "Nome")]
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }

        [Column(TypeName = "nvarchar")]
        [StringLength(80)]
        [Display(Name = "E-mail")]
        public string EmailUsuario { get => emailUsuario; set => emailUsuario = value; }

        
        [Required(ErrorMessage = "login é obrigatório!")]
        [Display(Name = "Adm")]
        public decimal Adm { get => adm; set => adm = value; }

        [ForeignKey("GrupoUsuario")]
        public Guid IdGrupo { get => idGrupo; set => idGrupo = value; }
        public GrupoUsuario GrupoUsuario { get => grupoUsuario; set => grupoUsuario = value; }
    }
}
