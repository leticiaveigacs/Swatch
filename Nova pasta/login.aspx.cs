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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Evento que é acionado quando o botão de entrar é clicado
        protected void btn_entrar_Click(object sender, EventArgs e)
        {
            // Expressões regulares para verificar diferentes critérios da senha
            Regex maiusculas = new Regex("[A-Z]");
            Regex minusculas = new Regex("[a-z]");
            Regex numeros = new Regex("[0-9]");
            Regex especial = new Regex("[^A-Za-z0-9]");
            Regex plicas = new Regex("'");

            // Estado inicial da força da senha
            string estado = "forte";

            // Verificações de força da senha
            if (tb_pw.Text.Length < 6)
                estado = "fraco";
            if (maiusculas.Matches(tb_pw.Text).Count == 0)
                estado = "fraco";
            if (minusculas.Matches(tb_pw.Text).Count == 0)
                estado = "fraco";
            if (numeros.Matches(tb_pw.Text).Count == 0)
                estado = "fraco";
            if (especial.Matches(tb_pw.Text).Count == 0)
                estado = "fraco";
            if (plicas.Matches(tb_pw.Text).Count > 0)
                estado = "fraco";
            // Exibe o estado da força da senha, com mensagem
            lbl_mensagem2.Text = estado;


            // Cria uma conexão com o banco de dados usando a string de conexão definida no Web.config
            SqlConnection myConn = new SqlConnection(ConfigurationManager.ConnectionStrings["swatchConnectionString"].ConnectionString);

            // Cria um comando SQL e define seu tipo como StoredProcedure
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "login";
            myCommand.Connection = myConn;

            // Adiciona os parâmetros necessários para a stored procedure
            myCommand.Parameters.AddWithValue("@util", tb_utilizador.Text);
            myCommand.Parameters.AddWithValue("@pw", tb_pw.Text);

            // Cria um parâmetro de saída para obter o resultado da stored procedure
            SqlParameter valor = new SqlParameter();
            valor.ParameterName = "@retorno";
            valor.Direction = ParameterDirection.Output;
            valor.SqlDbType = SqlDbType.Int;
            myCommand.Parameters.Add(valor);


            myConn.Open(); // Abre a conexão com o banco de dados
            myCommand.ExecuteNonQuery();  // Executa a stored procedure


            int respostaSQL = Convert.ToInt32(myCommand.Parameters["@retorno"].Value);

            myConn.Close();  // Fecha a conexão com o banco de dados

            if (respostaSQL == 1)
            {// Se o valor de saída for 1, define a sessão como validada e redireciona para a página "app.aspx"

                Session["validado"] = "sim";
                Session["utilizador"] = tb_utilizador.Text;
                Response.Redirect("app.aspx");
            }
            else
                // Se o valor de saída não for 1, exibe uma mensagem de erro
                lbl_mensagem.Text = "Utilizador e/ou palavra-passe errados! ";        



        }

        protected void btn_novo_Click(object sender, EventArgs e)
        {
            // Redireciona para a página "registar_utilizador.aspx" quando o botão "novo" é clicado
            Response.Redirect("registar_utilizador.aspx");
        }

        protected void btn_senha_Click(object sender, EventArgs e)
        {
            // Redireciona para a página "gestao_senha.aspx" quando o botão "senha" é clicado

            //cria variavel de sessao
            //Session["utilizador"] = tb_utilizador.Text;
            //Session["senha"] = tb_pw.Text;

            //Response.Redirect("gestao_senha.aspx");
        }
    }
}