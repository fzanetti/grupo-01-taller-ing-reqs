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
using SGGEA.UserControls;

namespace SGGEA.Perfiles
{
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
            showPerfiles();
        }

        private void showPerfiles()
        {
            foreach (Perfil perfil in API.Controladores.Perfiles.ObtenerPerfiles())
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Admin));
                Profile prf = new Profile();
                prf.BackColor = System.Drawing.Color.FromArgb(250,250,250);
                prf.Font = new System.Drawing.Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                prf.ForeColor = System.Drawing.Color.FromArgb(33,33,33);
                prf.Location = new System.Drawing.Point(18, 18);
                prf.Margin = new System.Windows.Forms.Padding(18, 18, 0, 0);
                prf.Name = "profile" + perfil.Id;
                prf.Nombre = perfil.Nombre;
                prf.Size = new System.Drawing.Size(300, 38);
                this.flowLayoutPanel.Controls.Add(prf);
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

        private void btnAltaPerfil_Click(object sender, EventArgs e)
        {
            FormPrincipal.getInstancia().InitializeAltaPerfil();
        }

        private void btnAltaPerfil_MouseEnter(object sender, EventArgs e)
        {
            this.btnAltaPerfil.Image = global::SGGEA.Properties.Resources.altaPerfilHover;
        }

        private void btnAltaPerfil_MouseLeave(object sender, EventArgs e)
        {
            this.btnAltaPerfil.Image = global::SGGEA.Properties.Resources.altaPerfil;
        }
    }
}
