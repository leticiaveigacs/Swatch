using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Site_Projeto
{
    public partial class registar_utilizador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Evento que é acionado quando o botão de registrar é clicado
        protected void btn_registar_Click(object sender, EventArgs e)
        {

            // Expressões regulares para verificar diferentes critérios da palavra-passe
            Regex maiusculas = new Regex("[A-Z]");
            Regex minusculas = new Regex("[a-z]");
            Regex numeros = new Regex("[0-9]");
            Regex especial = new Regex("[^A-Za-z0-9]");
            Regex plicas = new Regex("'");

            // Estado inicial da força da palavra-passe
            string estado = "forte";


            // Verificações de força da palavra-passe
            if (tb_tw.Text.Length < 6)
                estado = "fraco";
            if (maiusculas.Matches(tb_tw.Text).Count == 0)
                estado = "fraco";
            if (minusculas.Matches(tb_tw.Text).Count == 0)
                estado = "fraco";
            if (numeros.Matches(tb_tw.Text).Count == 0)
                estado = "fraco";
            if (especial.Matches(tb_tw.Text).Count == 0)
                estado = "fraco";
            if (plicas.Matches(tb_tw.Text).Count > 0)
                estado = "fraco";


            // Exibir o estado da força da palavra-passe
            lbl_mensagem2.Text = estado;





            // Cria uma conexão com o banco de dados usando a string de conexão definida no Web.config
            SqlConnection myConn = new SqlConnection(ConfigurationManager.ConnectionStrings["swatchConnectionString"].ConnectionString);

            // Cria um comando SQL e define seu tipo como StoredProcedure
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "inserir_utilizadores";
            myCommand.Connection = myConn;

            // Adiciona os parâmetros necessários para a stored procedure
            myCommand.Parameters.AddWithValue("@util", tb_utilizador.Text);
            myCommand.Parameters.AddWithValue("@pw", tb_tw.Text);

            // Cria um parâmetro de saída para obter o resultado da stored procedure
            SqlParameter valor = new SqlParameter();
            valor.ParameterName = "@retorno";
            valor.Direction = ParameterDirection.Output;
            valor.SqlDbType = SqlDbType.Int;
            myCommand.Parameters.Add(valor);


            myConn.Open(); // Abre a conexao com base de dados
            myCommand.ExecuteNonQuery(); // Executa a stored procedure


            int respostaSQL = Convert.ToInt32(myCommand.Parameters["@retorno"].Value);

            myConn.Close(); //Fecha a conexao com base de dados


            if (respostaSQL == 1)
            {
                lbl_mensagem.Text = "Utilizador inserido com sucesso!!"; // Se a saida for 1 , mostar uma mensasem de sucesso 
            }
            else

                lbl_mensagem.Text = "Utilizador já existe "; // Se a saida for 1 , mostar uma mensasem de erro

        }

        //protected void btn_senha_Click(object sender, EventArgs e)
        //{
        //    //Session["utilizador"] = tb_utilizador.Text;
        //    //Session["senha"] = tb_tw.Text;

        //    //Response.Redirect("gestao_senha.aspx");
            
        //}
    }
}