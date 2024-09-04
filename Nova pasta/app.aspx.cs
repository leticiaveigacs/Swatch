using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site_Projeto
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        // Este envento ocorre quando a página é carregada
        protected void Page_Load(object sender, EventArgs e)
        {
            // Atribui o valor da sessão "utilizador" ao texto do rótulo "lbl_utilizador"
            lbl_utilizador.Text = Session["utilizador"].ToString();

            // Verifica se a sessão "validado" é nula, se for, redireciona para a página "login.aspx"
            if (Session["validado"] == null) 
            {
                Response.Redirect("login.aspx");
            }

          
        }

        protected void btn_inscricao_Click(object sender, EventArgs e)
        {
            // Redireciona para a página "inscricao.aspx" quando o botão "inscriçao" é clicado
            Response.Redirect("inscricao.aspx");

        }

        protected void btn_gestao_Click(object sender, EventArgs e)
        {
            // Redireciona para a página ""gestao_utilizadores.aspx" quando o botão "gestao" é clicado
            Response.Redirect("gestao_utilizadores.aspx");
        }
    }
}