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

namespace SGGEA.Usuarios
{
    public partial class ModificacionBaja : UserControl, ToastObserver
    {
        private Usuario _usuario;
        List<SelPerfil> _perfiles;

        public ModificacionBaja(string username)
        {
            this._usuario = API.Controladores.Usuarios.ObtenerUsuario(username);
            InitializeComponent();
            lblTitulo.Text = _usuario.Username;
            _perfiles = new List<SelPerfil>();
            AgregarPerfiles();
            lblErrorPerfiles.Text = Globals.ErrorSelPerfiles;
            this.confirmBaja.setConfirmationClickEvent(this.btnConfirmarBaja_Click);
            this.confirmBaja.setCancelClickEvent(this.btnCancelarBaja_Click);
            toast.AddToastObserver(this);
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            campoPassword.TextoCampo = _usuario.Password;
            campoNombre.TextoCampo = _usuario.Nombre;
            campoApellido.TextoCampo = _usuario.Apellido;
            campoEmail.TextoCampo = _usuario.Email;
            campoPlanta.TextoCampo = _usuario.Planta;
            campoUbicacion.TextoCampo = _usuario.UbicacionFisica;
            campoDto.TextoCampo = _usuario.Departamento;
            campoCargo.TextoCampo = _usuario.Cargo;

            foreach (SelPerfil selPer in _perfiles)
            {
                if (_usuario.Perfiles.Find(p => p.Id == selPer.getPerfil().Id) != null)
                {
                    selPer.Seleccionado = true;
                }
            }  
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormPrincipal.getInstancia().InitializeAdminUsuarios();
        }

        private void btnSelPerfiles_Click(object sender, EventArgs e)
        {
            this.panelPerfiles.Visible = true;
        }

        private void btnAceptarPerfiles_Click(object sender, EventArgs e)
        {
            this.panelPerfiles.Visible = false;
        }

        private void AgregarPerfiles()
        {
            int i = 1;
            foreach (Perfil p in API.Controladores.Perfiles.ObtenerPerfiles())
            {
                SelPerfil selPerfil = new SelPerfil(p);
                selPerfil.BackColor = System.Drawing.Color.Transparent;
                selPerfil.MaximumSize = new System.Drawing.Size(200, 38);
                selPerfil.MinimumSize = new System.Drawing.Size(200, 20);
                selPerfil.Name = "selPerfil" + i;
                selPerfil.Size = new System.Drawing.Size(200, 22);
                this.flowLayoutPerfiles.Controls.Add(selPerfil);
                _perfiles.Add(selPerfil);
                i++;
            }
        }

        private bool ValidarCampoCompletado(CustomTextBox campo)
        {
            if (String.IsNullOrEmpty(campo.TextoCampo.Trim()))
            {
                campo.TextoError = Globals.ErrorCampoObl;
                return false;
            }
            else
            {
                campo.TextoError = String.Empty;
                return true;
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string password = campoPassword.TextoCampo.Trim();
            string nombre = campoNombre.TextoCampo.Trim();
            string apellido = campoApellido.TextoCampo.Trim();
            string email = campoEmail.TextoCampo.Trim();
            string planta = campoPlanta.TextoCampo.Trim();
            string ubicacion = campoUbicacion.TextoCampo.Trim();
            string departamento = campoDto.TextoCampo.Trim();
            string cargo = campoCargo.TextoCampo.Trim();

            bool camposCompletos = true;
 
            if (!ValidarCampoCompletado(campoPassword))
                camposCompletos = false;

            if (!ValidarCampoCompletado(campoNombre))
                camposCompletos = false;

            if (!ValidarCampoCompletado(campoApellido))
                camposCompletos = false;

            if (!ValidarCampoCompletado(campoEmail))
                camposCompletos = false;

            if (!ValidarCampoCompletado(campoPlanta))
                camposCompletos = false;

            if (!ValidarCampoCompletado(campoUbicacion))
                camposCompletos = false;

            if (!ValidarCampoCompletado(campoDto))
                camposCompletos = false;

            if (!ValidarCampoCompletado(campoCargo))
                camposCompletos = false;

            List<Perfil> perfilesUsuario = new List<Perfil>();
            foreach (SelPerfil selPer in _perfiles)
            {
                if (selPer.Seleccionado)
                {
                    perfilesUsuario.Add(selPer.getPerfil());
                }
            }
            if (perfilesUsuario.Count == 0)
            {
                lblErrorPerfiles.Visible = true;
                camposCompletos = false;
            }
            else
            {
                lblErrorPerfiles.Visible = false;
            }

            if (camposCompletos)
            {
                _usuario.Password = password;
                _usuario.Nombre = nombre;
                _usuario.Apellido = apellido;
                _usuario.Email = email;
                _usuario.Planta = planta;
                _usuario.UbicacionFisica = ubicacion;
                _usuario.Departamento = departamento;
                _usuario.Cargo = cargo;
                _usuario.Perfiles = perfilesUsuario;
                bool modificacionOk = API.Controladores.Usuarios.ModificarUsuario(_usuario);
                if (modificacionOk)
                {
                    toast.MostrarMensaje(Globals.ModificacionUsuarioOk);
                }
                else
                {
                    toast.MostrarMensaje(Globals.ModificacionUsuarioError,false);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            confirmBaja.Visible = true;
        }

        private void btnConfirmarBaja_Click(object sender, EventArgs e)
        {
            this.confirmBaja.Visible = false;
            bool eliminacionOk = API.Controladores.Usuarios.EliminarUsuario(_usuario);
            if (eliminacionOk)
            {
                toast.MostrarMensaje(Globals.BajaUsuarioOk);
            }
            else
            {
                toast.MostrarMensaje(Globals.BajaUsuarioError,false);
            }
        }

        private void btnCancelarBaja_Click(object sender, EventArgs e)
        {
            this.confirmBaja.Visible = false;
        }

        public void AccionPosterior()
        {
            FormPrincipal.getInstancia().InitializeAdminUsuarios();
        }
    }
}
