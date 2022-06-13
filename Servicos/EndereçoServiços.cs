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
            conexao = new SQLiteConnection("Data Source =C:\\Users\\Lucas Veloso\\OneDrive\\Área de Trabalho\\P2Dengue\\Banco\\banco_Dengue.db");
            {
                conexao.Open();
                return conexao;
            }
        }
        static List<Endereco> lst = new List<Endereco>();
        public static void NovoEndereco(Endereco e)
        {
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "insert into Endereço ( Logradouro,Bairro,Cep) values (@Logradouro, @Bairro, @Cep)";
            cmd.Parameters.AddWithValue("@Logradouro", e.Logradouro);
            cmd.Parameters.AddWithValue("@Bairro", e.Bairro);
            cmd.Parameters.AddWithValue("@Cep", e.Cep);
            lst.Add(e);
            cmd.ExecuteNonQuery();
            conexaoBanco().Close();

        }
        public static DataTable ObterTodosEnderecos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT *from Endereço";
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
