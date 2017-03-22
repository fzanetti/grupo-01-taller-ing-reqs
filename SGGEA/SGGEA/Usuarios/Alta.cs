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
    public partial class Alta : UserControl, ToastObserver
    {
        List<SelPerfil> _perfiles;

        public Alta()
        {
            InitializeComponent();
            _perfiles = new List<SelPerfil>();
            AgregarPerfiles();
            lblErrorPerfiles.Text = Globals.ErrorSelPerfiles;
            toast.AddToastObserver(this);
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
            campo.TextoError = String.Empty;
            if (String.IsNullOrEmpty(campo.TextoCampo.Trim()))
            {
                campo.TextoError = Globals.ErrorCampoObl;
                return false;
            }
            return true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string username = campoUsername.TextoCampo.Trim();
            string password = campoPassword.TextoCampo.Trim();
            string nombre = campoNombre.TextoCampo.Trim();
            string apellido = campoApellido.TextoCampo.Trim();
            string email = campoEmail.TextoCampo.Trim();
            string planta = campoPlanta.TextoCampo.Trim();
            string ubicacion = campoUbicacion.TextoCampo.Trim();
            string departamento = campoDto.TextoCampo.Trim();
            string cargo = campoCargo.TextoCampo.Trim();

            bool validacionCorrecta = true;
            if (!ValidarCampoCompletado(campoUsername))
            {
                validacionCorrecta = false;
            }
            else
            {
                if (API.Controladores.Usuarios.ExisteUsuario(username))
                {
                    campoUsername.TextoError = Globals.ErrorUsernameRegistrado;
                    validacionCorrecta = false;
                }
            }

            if (!ValidarCampoCompletado(campoPassword))
                validacionCorrecta = false;

            if (!ValidarCampoCompletado(campoNombre))
                validacionCorrecta = false;

            if (!ValidarCampoCompletado(campoApellido))
                validacionCorrecta = false;

            if (!ValidarCampoCompletado(campoEmail))
                validacionCorrecta = false;

            if (!ValidarCampoCompletado(campoPlanta))
                validacionCorrecta = false;

            if (!ValidarCampoCompletado(campoUbicacion))
                validacionCorrecta = false;

            if (!ValidarCampoCompletado(campoDto))
                validacionCorrecta = false;

            if (!ValidarCampoCompletado(campoCargo))
                validacionCorrecta = false;

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
                validacionCorrecta = false;
            }
            else
            {
                lblErrorPerfiles.Visible = false;
            }

            if (validacionCorrecta)
            {
                Usuario nuevo = new Usuario();
                nuevo.Username = username;
                nuevo.Password = password;
                nuevo.Nombre = nombre;
                nuevo.Apellido = apellido;
                nuevo.Email = email;
                nuevo.Planta = planta;
                nuevo.UbicacionFisica = ubicacion;
                nuevo.Departamento = departamento;
                nuevo.Cargo = cargo;
                nuevo.Perfiles = perfilesUsuario;
                bool altaOk = API.Controladores.Usuarios.AltaUsuario(nuevo);
                if (altaOk)
                {
                    toast.MostrarMensaje(Globals.AltaUsuarioOk);
                }
                else
                {
                    toast.MostrarMensaje(Globals.AltaUsuarioError, false);
                }
            }
        }

        public void AccionPosterior()
        {
            FormPrincipal.getInstancia().InitializeAdminUsuarios();
        }
    }
}
