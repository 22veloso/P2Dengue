using Models;
using System.Data.SqlClient;

namespace Servicos
{
    public class UsuarioServicos
    {
        string stringConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileNameC:\USERS\LOGATTI\DOCUMENTS\DENGUE.MDF;";

        public void Inserir(Usuario usuario)
        {

            //InserirEndereco
            int idEndereco = new EnderecoServicos().InserirEndereco(usuario.Endereco);
            
            //Inserir o usuário:
            SqlConnection conexao = new SqlConnection(stringConn);
            string sql = "INSERT INTO usuario (Nome, Telefone, Email, IdEnderenco) values (@Nome, @Telefone, @Email, @IdEnderenco)";
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                comando.Parameters.AddWithValue("@Telefone", usuario.Telefone);
                comando.Parameters.AddWithValue("@Email", usuario.Email);
                comando.Parameters.AddWithValue("@IdEnderenco", idEndereco);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}