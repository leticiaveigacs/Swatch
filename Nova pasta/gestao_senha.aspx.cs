using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

namespace Site_Projeto
{
    public partial class gestão_senha : System.Web.UI.Page
    {

        // Evento que é acionado quando a página é carregada
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["validado"] == null)
            {
                Response.Redirect("login.aspx");
            }

            // Carrega os dados das variáveis de sessão nos controles do formulário
            txt_email.Text = Session["utilizador"].ToString();       
            tb_tw.Text = Session["senha"].ToString();
        }

        protected void btn_recuperar_Click(object sender, EventArgs e)
        {

            //SqlConnection myConn = new SqlConnection(ConfigurationManager.ConnectionStrings["swatchConnectionString"].ConnectionString);


            //SqlCommand myCommand = new SqlCommand();
            //myCommand.CommandType = CommandType.StoredProcedure;
            //myCommand.CommandText = "senha";
            //myCommand.Connection = myConn;


            //myCommand.Parameters.AddWithValue("@util", tb_utilizador.Text);
            //myCommand.Parameters.AddWithValue("@pw", tb_pw.Text);

            //SqlParameter valor = new SqlParameter();
            //valor.ParameterName = "@retorno";
            //valor.Direction = ParameterDirection.Output;
            //valor.SqlDbType = SqlDbType.Int;
            //myCommand.Parameters.Add(valor);


            //myConn.Open();
            //myCommand.ExecuteNonQuery();


            //int respostaSQL = Convert.ToInt32(myCommand.Parameters["@retorno"].Value);

            //myConn.Close();

            //if (respostaSQL == 1)
            //{

            //    Session["validado"] = "sim";
            //    //Session["utilizador"] = tb_utilizador.Text;
            //    Session["senha"] = tb_pw.Text;

            //    //Response.Redirect("app.aspx");
            //}
            //else

            // lbl_mensagem.Text = "Utilizador e/ou palavra-passe errados! ";



            //MailMessage email = new MailMessage();
            //SmtpClient servidor = new SmtpClient();

            //email.From = new MailAddress(tb_de2.Text);
            //email.To.Add(new MailAddress(tb_para2.Text));
            //email.Subject = $"Recuperação de Senha";

            //email.IsBodyHtml = true;
            //email.Body = $"<html><body>" +
            //             $"<p>Utilizador: {txt_email.Text}</p>" +
            //             $"<p>Senha: {tb_tw.Text}</p>" +
            //             $"</body></html>";


            //servidor.Host = "smtp.office365.com";
            //servidor.Port = 587;

            //servidor.Credentials = new NetworkCredential("leticia.silva.35960@formandos.cinel.pt",
            //    "senha");

            //servidor.EnableSsl = true;
            //servidor.Send(email);
        }


    }
}