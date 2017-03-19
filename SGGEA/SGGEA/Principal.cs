using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API.Controladores;

namespace SGGEA
{
    public partial class Principal : UserControl
    {
        private bool _menuActivo = false;
        private ILogin _login;

        public Principal()
        {
            InitializeComponent();
            _login = LoginService.getInstancia();
            this.btnAdminUsu.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_usuarios);
            this.btnAlertas.Visible = _login.UsuarioPuedeAcceder(Funciones.Alerta_de_fallas_del_sistema);
            this.btnBitacoraAct.Visible = _login.UsuarioPuedeAcceder(Funciones.Visualizacion_de_registro_de_actividad_de_usuario);
            this.btnBitacoraFallas.Visible = _login.UsuarioPuedeAcceder(Funciones.Visualizacion_de_la_bitacora_de_fallas_del_sistema);
            this.btnConfigParam.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_parametros_del_sistema);
            this.btnMetricas.Visible = _login.UsuarioPuedeAcceder(Funciones.Visualizacion_de_metricas_historicas_de_energia);
            this.btnMonitor.Visible = _login.UsuarioPuedeAcceder(Funciones.Monitoreo_de_red_de_energia);
            this.btnOrdenAlimentacion.Visible = _login.UsuarioPuedeAcceder(Funciones.Configuracion_de_orden_de_alimentacion_de_energia);
            this.confirmLogout.setConfirmationClickEvent(this.btnConfirmarLogout_Click);
            this.confirmLogout.setCancelClickEvent(this.btnCancelarLogout_Click);
        }

        private void btnAdminUsu_MouseEnter(object sender, EventArgs e)
        {
            this.btnAdminUsu.BackgroundImage = global::SGGEA.Properties.Resources.adminUsuariosHover;
        }

        private void btnAdminUsu_MouseLeave(object sender, EventArgs e)
        {
            this.btnAdminUsu.BackgroundImage = global::SGGEA.Properties.Resources.adminUsuarios;
        }

        private void btnAdminUsu_Click(object sender, EventArgs e)
        {
            FormPrincipal.getInstancia().InitializeAdminUsuarios();
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            this.btnLogout.BackColor = System.Drawing.Color.LightGray;
            this.btnLogout.ForeColor = System.Drawing.Color.Gray;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogout.BackColor = Color.FromArgb(250, 250, 250);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            EsconderMenu();
            this.confirmLogout.Visible = true;
        }

        private void btnPerfilesUsuario_MouseEnter(object sender, EventArgs e)
        {
            this.btnPerfilesUsuario.BackColor = System.Drawing.Color.LightGray;
            this.btnPerfilesUsuario.ForeColor = System.Drawing.Color.Gray;
        }

        private void btnPerfilesUsuario_MouseLeave(object sender, EventArgs e)
        {
            this.btnPerfilesUsuario.BackColor = Color.FromArgb(250, 250, 250);
            this.btnPerfilesUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void btnPerfilesUsuario_Click(object sender, EventArgs e)
        {
            EsconderMenu();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (!_menuActivo)
            {
                this.btnMenu.Image = global::SGGEA.Properties.Resources.btnAtras;
                this.imgMenu.Visible = true;
                this.btnLogout.Visible = true;
                this.btnPerfilesUsuario.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_Perfiles_de_usuario);
                this.btnFunciones.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_Funciones);
                this.btnCompGen.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_sistema_de_componentes_generadores);
                this.btnBancos.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_bancos_de_almacenamiento);
                this.btnControlEnergia.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_sistema_de_control_de_energia);
                this.btnProvisionEnergia.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_sistema_de_provision_de_energia);
                this.btnConversionEnergia.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_sistema_de_conversion_de_energia);
                this.btnBancosBateria.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_bancos_de_baterias);
                this.Controls.SetChildIndex(this.btnPerfilesUsuario, 0);
                this.Controls.SetChildIndex(this.btnLogout, 1);
                this.Controls.SetChildIndex(this.imgMenu, 2);
                _menuActivo = true;
            }
            else
            {
                EsconderMenu();
            }
        }

        private void EsconderMenu()
        {
            this.btnMenu.Image = global::SGGEA.Properties.Resources.btnMenu;
            this.imgMenu.Visible = false;
            this.btnPerfilesUsuario.Visible = false;
            this.btnFunciones.Visible = false;
            this.btnCompGen.Visible = false;
            this.btnBancos.Visible = false;
            this.btnControlEnergia.Visible = false;
            this.btnProvisionEnergia.Visible = false;
            this.btnConversionEnergia.Visible = false;
            this.btnBancosBateria.Visible = false;
            this.btnLogout.Visible = false;
            _menuActivo = false;
        }

        private void btnConfirmarLogout_Click(object sender, EventArgs e)
        {
            this.confirmLogout.Visible = false;
            FormPrincipal.getInstancia().InitializeLogin();
        }

        private void btnCancelarLogout_Click(object sender, EventArgs e)
        {
            this.confirmLogout.Visible = false;
        }

    }
}
