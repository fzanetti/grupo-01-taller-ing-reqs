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
    public partial class ModificacionBaja : UserControl, ToastObserver
    {
        private Perfil _perfil;
        List<SelFuncion> _funciones;

        public ModificacionBaja(string nombrePerfil)
        {
            this._perfil = API.Controladores.Perfiles.ObtenerPerfil(nombrePerfil);
            InitializeComponent();
            lblTitulo.Text = nombrePerfil;
            _funciones = new List<SelFuncion>();
            this.confirmBaja.TextoMensaje = Globals.ConfirmacionBajaPerfil;
            AgregarFunciones();
            lblErrorFunciones.Text = Globals.ErrorSelFunciones;
            this.confirmBaja.setConfirmationClickEvent(this.btnConfirmarBaja_Click);
            this.confirmBaja.setCancelClickEvent(this.btnCancelarBaja_Click);
            toast.AddToastObserver(this);
            CargarDatosPerfil();
        }

        private void AgregarFunciones()
        {
            int i = 1;
            foreach (Funcion f in API.Controladores.Funciones.ObtenerFunciones())
            {
                SelFuncion selFuncion = new SelFuncion(f);
                selFuncion.BackColor = System.Drawing.Color.Transparent;
                selFuncion.AnchoNombre = 240;
                selFuncion.Name = "selFuncion" + i;
                selFuncion.Seleccionado = false;
                selFuncion.Size = new System.Drawing.Size(273, 40);
                selFuncion.TabIndex = i;
                this.flowLayoutFunciones.Controls.Add(selFuncion);
                _funciones.Add(selFuncion);
                i++;
            }
        }

        private void CargarDatosPerfil()
        {
            foreach (SelFuncion selFun in _funciones)
            {
                if (_perfil.Funciones.Find(f => f.Valor == selFun.getFuncion().Valor) != null)
                {
                    selFun.Seleccionado = true;
                }
            }  
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool validacionCorrecta = true;

            List<Funcion> funcionesPerfil = new List<Funcion>();
            foreach (SelFuncion selFun in _funciones)
            {
                if (selFun.Seleccionado)
                {
                    funcionesPerfil.Add(selFun.getFuncion());
                }
            }
            
            if (funcionesPerfil.Count == 0)
            {
                lblErrorFunciones.Visible = true;
                validacionCorrecta = false;
            }
            else
            {
                lblErrorFunciones.Visible = false;
            }

            if (validacionCorrecta)
            {
                _perfil.Funciones = funcionesPerfil;
                bool modificacionOk = API.Controladores.Perfiles.ModificarPerfil(_perfil);
                if (modificacionOk)
                {
                    toast.MostrarMensaje(Globals.ModificacionPerfilOk);
                }
                else
                {
                    toast.MostrarMensaje(Globals.ModificacionPerfilError, false);
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
            bool eliminacionOk = API.Controladores.Perfiles.EliminarPerfil(_perfil);
            if (eliminacionOk)
            {
                toast.MostrarMensaje(Globals.BajaPerfilOk);
            }
            else
            {
                toast.MostrarMensaje(Globals.BajaPerfilError, false);
            }
        }

        private void btnCancelarBaja_Click(object sender, EventArgs e)
        {
            this.confirmBaja.Visible = false;
        }

        public void AccionPosterior()
        {
            FormPrincipal.getInstancia().InitializeAdminPerfiles();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormPrincipal.getInstancia().InitializeAdminPerfiles();
        }
    }
}
