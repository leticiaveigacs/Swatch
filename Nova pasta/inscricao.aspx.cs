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
    //Classes 


    //Buton Radio List
    // Classe que representa uma categoria
    public class Category
    {
        public string Id { get; set; }    // Identificador da categoria
        public string Name { get; set; }  // Nome da categoria
    }


    // Modelo que contém uma lista de categorias e a resposta selecionada
    public class CategoryModel
    {
        public List<Category> ListCategory { get; set; }  // Lista de categorias
        public string SelectedAns { get; set; }           // Resposta selecionada
    }//fim


    public class CursoVM
    {
        public int Id { get; set; }     // Propriedade para o ID 
        public string Title { get; set; }  // Propriedade para o título ou nome 

        // Outras propriedades, podem ser adicionadas, conforme necessário
    }


   
    public partial class WebForm3 : System.Web.UI.Page
    {
        // Este envento ocorre quando a página é carregada
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verifica se a sessão "validado" é nula
            if (Session["validado"] == null)
            {
              // redireciona para a página "login.aspx"
   
                   Response.Redirect("login.aspx");
            }

        }//fim



        protected void ddl_regime_SelectedIndexChanged(object sender, EventArgs e)
        {
               
            // Converta o sender para um DropDownList
            DropDownList ddl_regime = sender as DropDownList;

           
             // Obtenha o valor selecionado
             string regime = ddl_regime.SelectedValue;

            // Defina a fonte de dados do DropDownList
             ddl_regime.DataSource = GetRegime(); // Supondo que GetCursos() retorne os dados desejados
             ddl_regime.DataTextField = "Title"; // Defina o campo de texto
             ddl_regime.DataValueField = "Id";    // Defina o campo de valor

                // Vincule os dados ao DropDownList
                ddl_cursos.DataBind();

                // Armazene o valor selecionado em uma variável de Sessão
                Session["regime"] = regime;
            // }


            // Limpa os itens do DropDownList
            ddl_cursos.Items.Clear();

            // Adiciona itens ao DropDownList com base no valor selecionado
            if (ddl_regime.SelectedItem.ToString() == "Diurno")
            {
                ddl_cursos.Items.Add("Relógios mecânicos complicados");
                ddl_cursos.Items.Add("Contadores e cronógrafos mecânicos");


            }
            else if (ddl_regime.SelectedItem.ToString() == "Noturno")
            {

                ddl_cursos.Items.Add("Adereço dos relógios de uso pessoal");
                ddl_cursos.Items.Add("Relógios electrónicos analógicos");
            }



        }

        //Dropdowlsit ddl_regime
        // Método para obter os regimes
        private List<CursoVM> GetRegime()
        {
            var cursos = new List<CursoVM>();

            // Adicione os cursos à lista
            cursos.Add(new CursoVM() { Id = 1, Title = "----------------------------------" });
            cursos.Add(new CursoVM() { Id = 2, Title = "Diurno" });
            cursos.Add(new CursoVM() { Id = 3, Title = "Noturno" });         

            return cursos;
        }

        //Eveno acionado quando o botao submeter é acionado
        protected void btn_submeter_Click(object sender, EventArgs e)
        {
           // Armazena os valores dos campos de texto em variáveis de sessão
            Session["nome"] = tb_nome.Text;
            Session["morada"] = tb_morada.Text;
            Session["email"] = tb_email.Text;
            Session["hobbies"] = cbl_hobbies.Text;
            Session["genero"] = rbl_genero.Text;
            Session["regime"] = ddl_regime.Text;
            Session["curso"] = ddl_cursos.Text;


            // Cria uma lista para armazenar os hobbies selecionados
            List<string> selectedHobbies = new List<string>();


            // Percorre cada item na lista de CheckBoxes `cbl_hobbies`.
            foreach (System.Web.UI.WebControls.ListItem item in cbl_hobbies.Items)
            { 
                // Verifica se o item atual está selecionado.
                if (item.Selected)
                {
                        selectedHobbies.Add(item.Text); // Se estiver selecionado, adiciona o texto do item à lista de hobbies selecionados.
                }
                 }

            //cria uma variavel hobbies
            // Armazena a lista de hobbies selecionados na variável de sessão "hobbies"
            Session["hobbies"] = cbl_hobbies.Text;
            Session["hobbies"] = selectedHobbies;

            // Redireciona para a página "dados.aspx"
            Response.Redirect("dados.aspx");
        }

   

        protected void rbl_genero_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Cria uma lista de categorias e adiciona os itens de gênero
            List<Category> clist = new List<Category>
            {
                new Category { Id = "F", Name = "Feminino" }, // Adiciona a categoria "Feminino" com Id "F"
                new Category { Id = "M", Name = "Masculino" } // Adiciona a categoria "Masculino" com Id "M"
            };

            // Inicializa o modelo de categoria com a lista de categorias e uma resposta selecionada vazia
            CategoryModel cm = new CategoryModel
            {
                ListCategory = clist,    // Atribui a lista de categorias ao modelo
                SelectedAns = string.Empty // Inicializa a resposta selecionada como vazia
            };

            // Armazena o modelo na Sessão para acessá-lo posteriormente
            Session["genero"] = cm;




        }


        protected void ddl_cursos_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Converta o sender para um DropDownList
            DropDownList ddl_cursos = sender as DropDownList;

            // Certifique-se de que ddl_cursos não é nulo antes de prosseguir
            if (ddl_cursos != null)
            {
                // Obtenha o valor selecionado
                string cursos = ddl_cursos.SelectedValue;

                // Defina a fonte de dados do DropDownList
                ddl_cursos.DataSource = GetCursos(); // Supondo que GetCursos() retorne os dados desejados
                ddl_cursos.DataTextField = "Title"; // Defina o campo de texto
                ddl_cursos.DataValueField = "Id";    // Defina o campo de valor

                // Finalmente, vincule os dados ao DropDownList
                ddl_cursos.DataBind();

                // Armazene o valor selecionado em uma variável de Sessão
                Session["cursos"] = cursos;
           }


        }

        //Dropdowlsit ddlcursos
        private List<CursoVM> GetCursos()
        {
            var cursos = new List<CursoVM>();

            // Adicione os cursos à lista
            cursos.Add(new CursoVM() { Id = 1, Title = "Relógios mecânicos complicados" });
            cursos.Add(new CursoVM() { Id = 2, Title = "Contadores e cronógrafos mecânicos" });
            cursos.Add(new CursoVM() { Id = 3, Title = "Adereço dos relógios de uso pessoal" });
            cursos.Add(new CursoVM() { Id = 4, Title = "Relógios electrónicos analógicos" });

            return cursos;
        }



        protected void cbl_hobbies_SelectedIndexChanged(object sender, EventArgs e)
        {
            // List<string> hobbiesSelecionados = new List<string>();

            // Percorre cada item na lista de CheckBoxes `cbl_hobbies`.
            // foreach (System.Web.UI.WebControls.ListItem item in cbl_hobbies.Items)
            //  {
            // Verifica se o item atual está selecionado.
            //      if (item.Selected)
            //      {
            // Se estiver selecionado, adiciona o texto do item à lista de hobbies selecionados.
            //          hobbiesSelecionados.Add(item.Text);
            //cria uma variavel hobbies
            //          Session["hobbies"] = cbl_hobbies.Text;
            //           Session["hobbies"] = hobbiesSelecionados;

            //      }
            //   }
        }


        //protected void btn_excel_Click(object sender, EventArgs e)
        ////{
        ////    Response.Clear();
        ////    Response.AddHeader("Content-Disposition", "attachment; filename=ficheiro.xls");

        ////    Response.ContentType = "application/vnd.ms-excel";
        ////    Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());

        ////    StringWriter sw = new StringWriter();
        ////    HtmlTextWriter htw = new HtmlTextWriter(sw);


        ////    //Session["hobbies"] = cbl_hobbies.Text;
        ////    //Session["genero"] = rbl_genero.Text;
        ////    //Session["regime"] = ddl_regime.Text;
        ////    //Session["cursos"] = ddl_cursos.Text;



        ////    // Escrever a tabela HTML com os dados do formulário          
        ////    htw.Write($"<html><body><table><tr><td><b>Nome:</b></td><td>{tb_nome.Text}</td></tr></table></body></html> <html><body><table><tr><td><b>Morada:</b></td><td>{tb_morada.Text}</td></tr></table></body></html><html><body><table><tr><td><b>E-mail:</b></td><td>{tb_email.Text}</td></tr></table></body></html>");

        ////    htw.Write($"< tr >< td >< b > Hobbies:</ b ></ td >< td >{ string.Join(", ", cbl_hobbies.Items.Cast<System.Web.UI.WebControls.ListItem>().Where(li => li.Selected).Select(li => li.Text))}</ td ></ tr");

        ////    htw.Write($"< tr >< td >< b > Gênero:</ b ></ td >< td >{rbl_genero.Text}</ td ></ tr");

        ////    htw.Write($"< tr >< td >< b > Regime:</ b ></ td >< td >{ ddl_regime.Text}</ td ></ tr");

        ////    htw.Write($"< tr >< td >< b > Curso:</ b ></ td >< td >{ ddl_cursos.Text}</ td ></ tr");





        ////    Response.Write(sw.ToString());
        ////    Response.End();
        //}

        //protected void btn_word_Click(object sender, EventArgs e)
        //{
        //    //Response.Clear();
        //    //Response.AddHeader("Content-Disposition", "attachment; filename=ficheiro.doc");

        //    //Response.ContentType = "application/vnd.ms-word";
        //    //Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());

        //    //StringWriter sw = new StringWriter();
        //    //HtmlTextWriter htw = new HtmlTextWriter(sw);

        //    ////Session["hobbies"] = cbl_hobbies.Text;
        //    ////Session["genero"] = rbl_genero.Text;
        //    ////Session["regime"] = ddl_regime.Text;
        //    ////Session["cursos"] = ddl_cursos.Text;





        //    //// Escrever a tabela HTML com os dados do formulário           
        //    //htw.Write($"<html><body><table><tr><td><b>Nome:</b></td><td>{tb_nome.Text}</td></tr></table></body></html> <html><body><table><tr><td><b>Morada:</b></td><td>{tb_morada.Text}</td></tr></table></body></html><html><body><table><tr><td><b>E-mail:</b></td><td>{tb_email.Text}</td></tr></table></body></html>< html >< body >< table >< tr >< td >< b > Nome:</ b ></ td >< td >{ cbl_hobbies.Text}</ td ></ tr ></ table ></ body ></ html >");


        //    //htw.Write($"< tr >< td >< b > Hobbies:</ b ></ td >< td >{ string.Join(", ", cbl_hobbies.Items.Cast<System.Web.UI.WebControls.ListItem>().Where(li => li.Selected).Select(li => li.Text))}</ td ></ tr");

        //    //htw.Write($"< tr >< td >< b > Gênero:</ b ></ td >< td >{rbl_genero.Text}</ td ></ tr");

        //    //htw.Write($"< tr >< td >< b > Regime:</ b ></ td >< td >{ ddl_regime.Text}</ td ></ tr");

        //    //htw.Write($"< tr >< td >< b > Curso:</ b ></ td >< td >{ ddl_cursos.Text}</ td ></ tr");


        //    //Response.Write(sw.ToString());
        //    //Response.End();
        //}

        //protected void btn_pdf_Click(object sender, EventArgs e)
        //{
        //    //Response.Clear();
        //    //Response.AddHeader("Content-Disposition", "attachment; filename=ficheiro.pdf");

        //    //Response.ContentType = "application/pdf";

        //    ////Session["hobbies"] = cbl_hobbies.Text;
        //    ////Session["genero"] = rbl_genero.Text;
        //    ////Session["regime"] = ddl_regime.Text;
        //    ////Session["cursos"] = ddl_cursos.Text;




        //    //// string texto = ($"< html >< body >< table >< tr >< td >< b > Nome:</ b ></ td >< td >{ tb_nome.Text}</ td ></ tr ></ table ></ body ></ html > < html >< body >< table >< tr >< td >< b > Morada:</ b ></ td >< td >{ tb_morada.Text}</ td ></ tr ></ table ></ body ></ html >< html >< body >< table >< tr >< td >< b > E - mail:</ b ></ td >< td >{ tb_email.Text}</ td ></ tr ></ table ></ body ></ html >< html >< body >< table >< tr >< td >< b > Nome:</ b ></ td >< td >{ cbl_hobbies.Text}</ td ></ tr ></ table ></ body ></ html >");


        //    //string texto = $"<html><body><table><tr><td><b>Nome:</b></td><td>{tb_nome.Text}</td></tr>" +
        //    //    $"<tr><td><b>Morada:</b></td><td>{tb_morada.Text}</td></tr>" +
        //    //    $"<tr><td><b>E-mail:</b></td><td>{tb_email.Text}</td></tr>" +
        //    //    $"<tr><td><b>Hobbies:</b></td><td>{string.Join(", ", cbl_hobbies.Items.Cast<System.Web.UI.WebControls.ListItem>().Where(li => li.Selected).Select(li => li.Text))}</td></tr>" +
        //    //    $"<tr><td><b> Gênero:</b></td><td>{rbl_genero.Text}</td></tr>" +
        //    //     $"<tr><td><b> Regime:</b></td><td>{ ddl_regime.Text}</td></tr>" +
        //    //      $"<tr><td><b> Curso:</b></td><td>{ ddl_cursos.Text}</td></tr>" +

        //    //  $"</table></body></html>";





        //    //StringReader sr = new StringReader(texto);

        //    //Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
        //    //HTMLWorker hworker = new HTMLWorker(pdfDoc);
        //    //PdfWriter.GetInstance(pdfDoc, Response.OutputStream);

        //    //pdfDoc.Open();
        //    //hworker.Parse(sr);
        //    //pdfDoc.Close();

        //    //Response.Write(pdfDoc);
        //    //Response.End();




        //}

        //protected void btn_enviar_Click(object sender, EventArgs e)
        //{

        //    //MailMessage email = new MailMessage();
        //    //SmtpClient servidor = new SmtpClient();

        //    //email.From = new MailAddress(tb_de.Text);
        //    //email.To.Add(new MailAddress(tb_para.Text));
        //    //email.Subject = $"Mensagem enviada por{tb_de.Text}<br/><b>Mensagem:</b>{ tb_assunto.Text}";

        //    //email.IsBodyHtml = true;
        //    ////email.Body = tb_mensagem.Text;

        //    //email.Body = $"<html><body><table><tr><td><b>Nome:</b></td><td>{tb_nome.Text}</td></tr>" +
        //    //   $"<tr><td><b>Morada:</b></td><td>{tb_morada.Text}</td></tr>" +
        //    //   $"<tr><td><b>E-mail:</b></td><td>{tb_email.Text}</td></tr>" +
        //    //   $"<tr><td><b>Hobbies:</b></td><td>{string.Join(", ", cbl_hobbies.Items.Cast<System.Web.UI.WebControls.ListItem>().Where(li => li.Selected).Select(li => li.Text))}</td></tr>" +
        //    //   $"<tr><td><b> Gênero:</b></td><td>{rbl_genero.Text}</td></tr>" +
        //    //    $"<tr><td><b> Regime:</b></td><td>{ ddl_regime.Text}</td></tr>" +
        //    //     $"<tr><td><b> Curso:</b></td><td>{ ddl_cursos.Text}</td></tr>" +
        //    // $"</table></body></html>";

        //    //////verificar o anexo
        //    ////if (FileUpload1.HasFile)
        //    ////{

        //    ////    Attachment anexo = new Attachment(FileUpload1.FileContent, FileUpload1.FileName);
        //    ////    email.Attachments.Add(anexo);
        //    ////}

        //    //servidor.Host = "smtp.office365.com";
        //    //servidor.Port = 587;

        //    //servidor.Credentials = new NetworkCredential("leticia.silva.35960@formandos.cinel.pt",
        //    //    "senha");

        //    //servidor.EnableSsl = true;
        //    //servidor.Send(email);

        //}


    }
}



