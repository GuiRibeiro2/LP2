using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PContato0030482413037
{
    internal class Cidade
    {
        public int IdCidade { get; set; }
        public string NomeCidade { get; set; }
        public string UfCidade { get; set; }

        public DataTable Listar()
        {
            SqlDataAdapter daCidade;

            DataTable dtCidade = new DataTable();

            try
            {
                daCidade = new SqlDataAdapter("SELECT * FROM CIDADE ORDER BY NOME_CIDADE", frmPrincipal.conexao);
                daCidade.Fill(dtCidade); //dados
                daCidade.FillSchema(dtCidade, SchemaType.Source); //inf. estrutura tabela
            }
            catch (Exception)
            {
                throw; // criar uma exceção
            }
            return dtCidade;
        }
    }
}
