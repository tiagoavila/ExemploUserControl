using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TesteUserControl
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //declaração do manipulador de eventos criado no UserControl
            UserControl.UserControlButtonClicked += new
                    EventHandler(UserControl_UserControlButtonClicked);
        }

        //Evento que será executado na página pai quando o evento do UserControl for disparado
        private void UserControl_UserControlButtonClicked(object sender, EventArgs e)
        {
            //evento da página aqui

        }
    }
}