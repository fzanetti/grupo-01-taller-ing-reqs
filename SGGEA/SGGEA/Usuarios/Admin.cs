using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGGEA.UserControls;
using API.Dominio;

namespace SGGEA.Usuarios
{
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
            showUsers();
        }

        private void showUsers()
        {
            int i=2;
            foreach (Usuario usuario in API.Controladores.Usuarios.ObtenerUsuarios()){
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Admin));
                User usr = new User();
                usr.BackColor = System.Drawing.Color.Transparent;
                usr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("user1.BackgroundImage")));
                usr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                usr.Font = new System.Drawing.Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                usr.Location = new System.Drawing.Point(34, 144);
                usr.Name = "usuario" + i;
                usr.NombreUsuario = usuario.Username;
                usr.NombreApellido = usuario.Nombre+" "+usuario.Apellido;
                usr.Email = usuario.Email;
                usr.Size = new System.Drawing.Size(333, 50);
                this.flowLayoutPanel.Controls.Add(usr);
                i++;
            }
            if (this.flowLayoutPanel.Controls.Count > 9)
            {
                this.flowLayoutPanel.Size = new System.Drawing.Size(360, 523);
                this.flowLayoutPanel.Location = new System.Drawing.Point(22, 143);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormPrincipal.getInstancia().InitializePrincipal();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            FormPrincipal.getInstancia().InitializeAltaUsuario();
        }

        private void btnAltaUsuario_MouseEnter(object sender, EventArgs e)
        {
            this.btnAltaUsuario.Image = global::SGGEA.Properties.Resources.altaUsuarioHover;
        }

        private void btnAltaUsuario_MouseLeave(object sender, EventArgs e)
        {
            this.btnAltaUsuario.Image = global::SGGEA.Properties.Resources.altaUsuario;
        }

    }
}
