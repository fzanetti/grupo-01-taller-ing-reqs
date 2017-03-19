using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API.Dominio;

namespace SGGEA.Usuarios
{
    public partial class ModificacionUsuario : UserControl
    {
        private Usuario _usuario;

        public ModificacionUsuario(string username)
        {
            this._usuario = API.Controladores.Usuarios.ObtenerUsuario(username);
            InitializeComponent();
            lblTitulo.Text = _usuario.Username;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormPrincipal.getInstancia().InitializeAdminUsuarios();
        }
    }
}
