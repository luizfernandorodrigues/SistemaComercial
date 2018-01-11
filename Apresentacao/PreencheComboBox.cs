using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
   public class PreencheComboBox
    {
        public string descricao { get; set; }
        public string valor { get; set; }

        /// <summary>
        /// Metodo de Criação dos Filtros das Combobox das Telas de Pesquisa, Recebe uma 
        /// Combobox como parametros e Retorna a mesma com seu dataSource Carregado e 
        /// Com o ValueMember, o mesmo segue uma ordem igual o Index
        /// </summary>
        /// <param name="cb"></param>
        /// <returns></returns>
        public ComboBox combo(ComboBox cb)
        {

            List<PreencheComboBox> lst = new List<PreencheComboBox>();
            lst.Add(new PreencheComboBox { descricao = "Iniciado Por", valor = "1" });
            lst.Add(new PreencheComboBox { descricao = "Igual", valor = "2" });
            lst.Add(new PreencheComboBox { descricao = "Entre", valor = "3" });
            lst.Add(new PreencheComboBox { descricao = "Maior Igual", valor = "4" });
            lst.Add(new PreencheComboBox { descricao = "Menor Igual", valor = "5" });
            lst.Add(new PreencheComboBox { descricao = "Contem", valor = "6" });
            lst.Add(new PreencheComboBox { descricao = "Diferente de", valor = "6" });
            lst.Add(new PreencheComboBox { descricao = "Terminado Por", valor = "7" });

            cb.DataSource = lst;
            cb.DisplayMember = "descricao";
            cb.ValueMember = "valor";

            return cb;

        }
    }
}
