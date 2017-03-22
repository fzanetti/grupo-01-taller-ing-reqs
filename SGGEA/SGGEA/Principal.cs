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
            btnAdminUsu.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_usuarios);
            btnAlertas.Visible = _login.UsuarioPuedeAcceder(Funciones.Alerta_de_fallas_del_sistema);
            btnBitacoraAct.Visible = _login.UsuarioPuedeAcceder(Funciones.Visualizacion_de_registro_de_actividad_de_usuario);
            btnBitacoraFallas.Visible = _login.UsuarioPuedeAcceder(Funciones.Visualizacion_de_la_bitacora_de_fallas_del_sistema);
            btnConfigParam.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_parametros_del_sistema);
            btnMetricas.Visible = _login.UsuarioPuedeAcceder(Funciones.Visualizacion_de_metricas_historicas_de_energia);
            btnMonitor.Visible = _login.UsuarioPuedeAcceder(Funciones.Monitoreo_de_red_de_energia);
            btnOrdenAlimentacion.Visible = _login.UsuarioPuedeAcceder(Funciones.Configuracion_de_orden_de_alimentacion_de_energia);
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
            FormPrincipal.getInstancia().InitializeAdminPerfiles();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (!_menuActivo)
            {
                this.btnMenu.Image = global::SGGEA.Properties.Resources.btnAtras;
                this.fondoMenu.Visible = true;
                this.btnLogout.Visible = true;
                this.btnPerfilesUsuario.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_Perfiles_de_usuario);
                this.btnFunciones.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_Funciones);
                this.btnCompGen.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_sistema_de_componentes_generadores);
                this.btnBancos.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_bancos_de_almacenamiento);
                this.btnControlEnergia.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_sistema_de_control_de_energia);
                this.btnProvisionEnergia.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_sistema_de_provision_de_energia);
                this.btnConversionEnergia.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_sistema_de_conversion_de_energia);
                this.btnBancosBateria.Visible = _login.UsuarioPuedeAcceder(Funciones.Admin_de_bancos_de_baterias);
                VerificarPosElementos();           
                _menuActivo = true;
            }
            else
            {
                EsconderMenu();
            }
        }

        private void VerificarPosElementos()
        {
            this.Controls.SetChildIndex(this.confirmLogout, 0);
            this.Controls.SetChildIndex(this.btnMenu, 1);
            this.Controls.SetChildIndex(this.lblTitulo, 2);
            this.Controls.SetChildIndex(this.btnBancosBateria, 3);
            this.Controls.SetChildIndex(this.btnConversionEnergia, 4);
            this.Controls.SetChildIndex(this.btnProvisionEnergia, 5);
            this.Controls.SetChildIndex(this.btnControlEnergia, 6);
            this.Controls.SetChildIndex(this.btnBancos, 7);
            this.Controls.SetChildIndex(this.btnCompGen, 8);
            this.Controls.SetChildIndex(this.btnFunciones, 9);
            this.Controls.SetChildIndex(this.btnPerfilesUsuario, 10);
            this.Controls.SetChildIndex(this.btnLogout, 11);
            this.Controls.SetChildIndex(this.fondoMenu, 12);
            this.Controls.SetChildIndex(this.btnBitacoraAct, 13);
            this.Controls.SetChildIndex(this.btnMetricas, 14);
            this.Controls.SetChildIndex(this.btnBitacoraFallas, 15);
            this.Controls.SetChildIndex(this.btnAdminUsu, 16);
            this.Controls.SetChildIndex(this.btnOrdenAlimentacion, 17);
            this.Controls.SetChildIndex(this.btnConfigParam, 18);
            this.Controls.SetChildIndex(this.btnAlertas, 19);
            this.Controls.SetChildIndex(this.btnMonitor, 20);
        }

        private void EsconderMenu()
        {
            this.btnMenu.Image = global::SGGEA.Properties.Resources.btnMenu;
            this.fondoMenu.Visible = false;
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
