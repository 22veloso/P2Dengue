using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;


namespace Servicos
{
    public class EndereçoServiços
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection conexaoBanco()

        {
            conexao = new SQLiteConnection(@"Data Source =C:\Users\Lucas Veloso\OneDrive\Área de Trabalho\P2Dengue\Banco\banco_Dengue.db");
            {
                conexao.Open();
                return conexao;
            }
        }
        static List<Endereco> lst = new List<Endereco>();
        public static long NovoEndereco(Endereco e)
        {
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "insert into Endereco ( Logradouro,Bairro,Cep) values (@Logradouro, @Bairro, @Cep); select last_insert_rowid()";
            cmd.Parameters.AddWithValue("@Logradouro", e.Logradouro);
            cmd.Parameters.AddWithValue("@Bairro", e.Bairro.Id);
            cmd.Parameters.AddWithValue("@Cep", e.Cep);
            lst.Add(e);
            Int64 idEndereco = (Int64)cmd.ExecuteScalar();
            conexaoBanco().Close();
            return idEndereco;

        }
        public static DataTable ObterTodosEnderecos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "select distinct B.descricao, (select count(*) from Endereco EI, Usuario U where EI.Bairro = E.Bairro and U.IdEndereco = EI.Id and U.status = 'SIM') as qtdCasos from Endereco E, Bairro B, Usuario U where E.Bairro = B.id and E.Id = U.IdEndereco and U.status = 'SIM' order by status";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }
}
