﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class CriaStringSql
    {
        private string tabela;
        private StringBuilder sql;
        private ArrayList campos = new ArrayList();
        private ArrayList valores = new ArrayList();
        private ArrayList where = new ArrayList();

        public CriaStringSql(string tabela)
        {
            this.tabela = tabela;
        }

        /// <summary>
        /// Metodo para adicionar campo e valor nas operações de "insert" e "update"
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="valor"></param>
        public void addCampo(string nome, string valor)
        {
            campos.Add(nome);
            valores.Add(valor);
        }

        /// <summary>
        /// Metodo para adicionar campo nas operações de "select"
        /// </summary>
        /// <param name="nome"></param>
        public void addCampo(string nome)
        {
            addCampo(nome, string.Empty);
        }

        /// <summary>
        /// Metodo para adicionar a clausula "where"
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="valor"></param>
        public void addWhere(string nome, string valor, string operador, string valorEntre)
        {
            string valorFinal = "";

            switch (operador)
            {
                //iniciado por
                case "1":
                    valorFinal += "%";
                    break;
                //igual
                case "2":
                    valorFinal = "=" + valor;
                    break;
                //case "3":


            }
            if (where.Count == 0)
            {
                where.Add("WHERE " + nome + "'" + operador + valor + "'");
                return;
            }
            else
            {
                where.Add(where[where.Count - 1] + " AND " + nome + operador + "'" + valor + "'");
            }
        }

        public string insert()
        {
            sql = new StringBuilder();
            sql.Append("INSERT INTO ");
            sql.Append(tabela);
            sql.Append(" (");

            //loop para adicionar todos os campo do insert
            for (int i = 0; i < campos.Count; i++)
            {
                if (i == campos.Count - 1)
                {
                    sql.Append(campos[i]);
                }
                else
                {
                    sql.Append(campos[i] + ",");
                }
            }
            sql.Append(") VALUES(");

            //loop para adicionar valores do insert
            for (int i = 0; i < valores.Count; i++)
            {
                if (i == valores.Count - 1)
                {
                    sql.Append(valores[i]);
                }
                else
                {
                    sql.Append(valores[i] + ",");
                }
            }
            sql.Append(")");

            return sql.ToString();
        }

        public String select()
        {
            sql = new StringBuilder();
            sql.Append("SELECT ");
            //loop para adicionar todos campos do select
            for (int i = 0; i < campos.Count; i++)
            {
                if (i == campos.Count - 1)
                {
                    sql.Append(campos[i]);
                }
                else
                {
                    sql.Append(campos[i] + ",");
                }
            }

            sql.Append(" FROM " + tabela);

            if (where.Count != 0)
            {
                sql.Append(" " + where[where.Count - 1]);
            }
            return sql.ToString();
        }


    }
}
