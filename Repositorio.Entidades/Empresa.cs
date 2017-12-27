using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    [Table("tblEmpresa")]
    public class Empresa
    {
        private Guid ukey;
        private Cep cep;
        private Guid idCep;
        private string codigoEmpresa;
        private string fantasiaEmpresa;
        private string razaoEmpresa;
        private string endereco;
        private string numeroEndereco;
        private string complementoEnd;
        private string bairroEndereco;
        private string cnpj;
        private string inscricao;
        private string telefone;
        private string celular;
        private string fax;
        private string email;

        [Key]
        public Guid Ukey { get => ukey; set => ukey = value; }

        [ForeignKey("Cep")]
        public Guid IdCep { get => idCep; set => idCep = value; }
        public Cep Cep { get => cep; set => cep = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "Código da Empresa é obrigatório!")]
        [StringLength(20)]
        public string CodigoEmpresa { get => codigoEmpresa; set => codigoEmpresa = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Fantasia")]
        [Required(ErrorMessage = "Nome fantasia obrigatorio")]
        [StringLength(50)]
        public string FantasiaEmpresa { get => fantasiaEmpresa; set => fantasiaEmpresa = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Razão Social")]
        [Required(ErrorMessage = "Razão Social é obrigatorio")]
        [StringLength(80)]
        public string RazaoEmpresa { get => razaoEmpresa; set => razaoEmpresa = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Endereço obrigatorio")]
        [StringLength(80)]
        public string Endereco { get => endereco; set => endereco = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Nomero do Endereço")]
        [StringLength(20)]
        public string NumeroEndereco { get => numeroEndereco; set => numeroEndereco = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Complemento")]
        [StringLength(30)]
        public string ComplementoEnd { get => complementoEnd; set => complementoEnd = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "Bairro é obrigatorio")]
        [StringLength(50)]
        public string BairroEndereco { get => bairroEndereco; set => bairroEndereco = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Cnpj")]
        [Required(ErrorMessage = "Cnpj obrigatorio")]
        [StringLength(14)]
        public string Cnpj { get => cnpj; set => cnpj = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Inscrição")]
        [StringLength(14)]
        public string Inscricao { get => inscricao; set => inscricao = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Telefone")]
        [StringLength(11)]
        public string Telefone { get => telefone; set => telefone = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Celular")]
        [StringLength(11)]
        public string Celular { get => celular; set => celular = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Fax")]
        [StringLength(11)]
        public string Fax { get => fax; set => fax = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "E-mail")]
        [StringLength(100)]
        public string Email { get => email; set => email = value; }
    }
}
