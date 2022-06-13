using Models;
using System.Data;
using System.Data.SQLite;

namespace Servicos
{
    public class UsuarioServicos

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
 
        static List<Usuario> lst = new List<Usuario>();
       public static void NovoUsuario(Usuario u)
        {
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "insert into Usuario ( Nome,Email, Telefone) values (@Nome, @Email, @Telefone)";
            cmd.Parameters.AddWithValue("@Nome", u.Nome);
            cmd.Parameters.AddWithValue("@Email", u.Email);
            cmd.Parameters.AddWithValue("@Telefone", u.Telefone);
            lst.Add(u);
            cmd.ExecuteNonQuery();
            conexaoBanco().Close();

        
            

            

        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
                DataTable dt= new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd= vcon.CreateCommand();
                cmd.CommandText = "SELECT *from Usuario";
                da= new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
             catch(Exception ex)
            {
                throw ex;
            }
        }


        }
        }
