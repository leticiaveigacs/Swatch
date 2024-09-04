using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Net;
using System.Net.Mail;



namespace Site_Projeto
{
    public partial class exemplo1 : System.Web.UI.Page
    {
        // Este envento ocorre quando a página é carregada
        protected void Page_Load(object sender, EventArgs e)
        {

            // Verifica se a sessão "validado" é nula
            if (Session["validado"] == null)
            {
              //  redireciona para a página "login.aspx"
                Response.Redirect("login.aspx");
            }

            // Carrega os dados das variáveis de sessão nos controles do formulário
            tb_nome.Text = Session["nome"].ToString();
            tb_morada.Text = Session["morada"].ToString();
            tb_email.Text = Session["email"].ToString();
            cbl_hobbies.Text = Session["hobbies"].ToString();         
            rbl_genero.Text = Session["genero"].ToString();
            ddl_regime.Text = Session["regime"].ToString();
            ddl_cursos.Text = Session["cursos"].ToString();

            

            // Verifica se a sessão "hobbies" não é nula e define o texto da CheckBoxList(multipla selecao)
            if (Session["hobbies"] != null)
              {
                  List<string> hobbies = (List<string>)Session["hobbies"];
                   cbl_hobbies.Text = string.Join(", ", hobbies);
               }

            // string.Join(", ", cbl_hobbies.Text.Cast<System.Web.UI.WebControls.ListItem>().Where(li => li.Selected).Select(li => li.Text))

                    

        }

        // Método para gerar e baixar um ficheiro Excel
        protected void btn_excel2_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=ficheiro.xls");

            Response.ContentType = "application/vnd.ms-excel";
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());

            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);

           

            // Escrever a tabela HTML com os dados do formulário
           htw.Write($"<html><body><table><tr><td><b>Nome:</b></td><td>{tb_nome.Text}</td></tr></table></body></html> <html><body><table><tr><td><b>Morada:</b></td><td>{tb_morada.Text}</td></tr></table></body></html><html><body><table><tr><td><b>E-mail:</b></td><td>{tb_email.Text}</td></tr></table></body></html>");

            htw.Write($"< tr >< td >< b > Hobbies:</ b ></ td >< td >{cbl_hobbies.Text}</ td ></ tr");

            htw.Write($"< tr >< td >< b > Gênero:</ b ></ td >< td >{rbl_genero.Text}</ td ></ tr");

            htw.Write($"< tr >< td >< b > Regime:</ b ></ td >< td >{ ddl_regime.Text}</ td ></ tr");

            htw.Write($"html><body><table><tr><td><b>Curso:</b></td><td>{ddl_cursos.Text}</td></tr></table></body></html>");


            Response.Write(sw.ToString());
            Response.End();
        }

        // Método para gerar e baixar um ficheiro Word
        protected void btn_word2_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=ficheiro.doc");

            Response.ContentType = "application/vnd.ms-word";
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());

            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);

        


            // Escrever a tabela HTML com os dados do formulário
            htw.Write($"<html><body><table><tr><td><b>Nome:</b></td><td>{tb_nome.Text}</td></tr></table></body></html> <html><body><table><tr><td><b>Morada:</b></td><td>{tb_morada.Text}</td></tr></table></body></html><html><body><table><tr><td><b>E-mail:</b></td><td>{tb_email.Text}</td></tr></table></body></html>");

            htw.Write($"< tr >< td >< b > Hobbies:</ b ></ td >< td >{cbl_hobbies.Text}</ td ></ tr");

            htw.Write($"< tr >< td >< b > Gênero:</ b ></ td >< td >{rbl_genero.Text}</ td ></ tr");

            htw.Write($"< tr >< td >< b > Regime:</ b ></ td >< td >{ ddl_regime.Text}</ td ></ tr");

            htw.Write($"html><body><table><tr><td><b>Curso:</b></td><td>{ddl_cursos.Text}</td></tr></table></body></html>");


            Response.Write(sw.ToString());
            Response.End();
        }



        // Método para gerar e baixar um ficheiro  PDF
        protected void btn_pdf2_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=ficheiro.pdf");

            Response.ContentType = "application/pdf";


            // Escrever a tabela HTML com os dados do formulário
            string texto = $"<html><body><table><tr><td><b>Nome:</b></td><td>{tb_nome.Text}</td></tr>" +
                   $"<tr><td><b>Morada:</b></td><td>{tb_morada.Text}</td></tr>" +
                   $"<tr><td><b>E-mail:</b></td><td>{tb_email.Text}</td></tr>" +
                   $"<tr><td><b>Hobbies:</b></td><td>{cbl_hobbies.Text}</td></tr>" +
                   $"<tr><td><b>Gênero:</b></td><td>{rbl_genero.Text}</td></tr>" +
                   $"<tr><td><b>Curso:</b></td><td>{ddl_cursos.Text}</td></tr>" +
                   $"<tr><td><b>Regime:</b></td><td>{ddl_regime.Text}</td></tr></table></body></html>";



            StringReader sr = new StringReader(texto);

            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
            HTMLWorker hworker = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);

            pdfDoc.Open();
            hworker.Parse(sr);
            pdfDoc.Close();

            Response.Write(pdfDoc);
            Response.End();

        }

        //  Método para enviar um e-mail com os dados do formulário
        protected void btn_email2_Click(object sender, EventArgs e)
        {

            MailMessage email = new MailMessage();
            SmtpClient servidor = new SmtpClient();

            email.From = new MailAddress(tb_de.Text);
            email.To.Add(new MailAddress(tb_para.Text));
            email.Subject = $"Mensagem enviada por{tb_de.Text}<br/><b>Mensagem:</b>{ tb_assunto.Text}";

            email.IsBodyHtml = true;
            //email.Body = tb_mensagem.Text;

            // Escrever a tabela HTML com os dados do formulário
            email.Body = $"<html><body><table><tr><td><b>Nome:</b></td><td>{tb_nome.Text}</td></tr>" +
                   $"<tr><td><b>Morada:</b></td><td>{tb_morada.Text}</td></tr>" +
                   $"<tr><td><b>E-mail:</b></td><td>{tb_email.Text}</td></tr>" +
                   $"<tr><td><b>Hobbies:</b></td><td>{cbl_hobbies.Text}</td></tr>" +
                   $"<tr><td><b>Gênero:</b></td><td>{rbl_genero.Text}</td></tr>" +
                   $"<tr><td><b>Curso:</b></td><td>{ddl_cursos.Text}</td></tr>" +
                   $"<tr><td><b>Regime:</b></td><td>{ddl_regime.Text}</td></tr></table></body></html>";


            // Configuraçoes servidor
            servidor.Host = "smtp.office365.com";
            servidor.Port = 587;

            servidor.Credentials = new NetworkCredential("leticia.silva.35960@formandos.cinel.pt",
                "senha");

            servidor.EnableSsl = true;
            servidor.Send(email);
        }

      
    }
    
}

