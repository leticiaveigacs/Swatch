using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site_Projeto
{
    public partial class gestao_utilizadores : System.Web.UI.Page
    {
        // Este envento ocorre quando a página é carregada
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verifica se a sessão "validado" é nula
            if (Session["validado"] == null)
            {
                //redireciona para a página "login.aspx"
                Response.Redirect("login.aspx");
            }
        }
    }
}