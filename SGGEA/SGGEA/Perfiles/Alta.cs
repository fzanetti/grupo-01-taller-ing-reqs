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

namespace SGGEA.Perfiles
{
    public partial class Alta : UserControl, ToastObserver
    {
        List<SelFuncion> _funciones;

        public Alta()
        {
            InitializeComponent();
            _funciones = new List<SelFuncion>();            
            toast.AddToastObserver(this);
            lblErrorFunciones.Text = Globals.ErrorSelFunciones;
            AgregarFunciones();
        }

        private void AgregarFunciones()
        {
            int i = 1;
            foreach (Funcion f in API.Controladores.Funciones.ObtenerFunciones())
            {
                SelFuncion selFuncion = new SelFuncion(f);
                selFuncion.BackColor = System.Drawing.Color.Transparent;
                selFuncion.Name = "selFuncion"+i;
                selFuncion.Seleccionado = false;
                selFuncion.Size = new System.Drawing.Size(257, 40);
                selFuncion.TabIndex = i;
                this.flowLayoutFunciones.Controls.Add(selFuncion);
                _funciones.Add(selFuncion);
                i++;
            } 
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombreFuncion = campoNombre.TextoCampo.Trim();

            bool validacionCorrecta = true;

            campoNombre.TextoError = String.Empty;

            if (String.IsNullOrEmpty(campoNombre.TextoCampo.Trim()))
            {
                campoNombre.TextoError = Globals.ErrorCampoObl;
                validacionCorrecta = false;
            }
            else
            {
                if (API.Controladores.Perfiles.ExistePerfil(nombreFuncion))
                {
                    campoNombre.TextoError = Globals.ErrorPerfilRegistrado;
                    validacionCorrecta = false;
                }
            }

            List<Funcion> funcionesPerfil = new List<Funcion>();
            foreach (SelFuncion selFun in _funciones)
            {
                if (selFun.Seleccionado)
                {
                    funcionesPerfil.Add(selFun.getFuncion());
                }
            }
            lblErrorFunciones.Visible = false;
            if (funcionesPerfil.Count == 0)
            {
                lblErrorFunciones.Visible = true;
                validacionCorrecta = false;
            }

            if (validacionCorrecta)
            {
                Perfil nuevo = new Perfil();
                nuevo.Nombre = nombreFuncion;
                nuevo.Funciones = funcionesPerfil;
                bool altaOk = API.Controladores.Perfiles.AltaPerfil(nuevo);
                if (altaOk)
                {
                    toast.MostrarMensaje(Globals.AltaPerfilOk);
                }
                else
                {
                    toast.MostrarMensaje(Globals.AltaPerfilError, false);
                }
            }
        }

        public void AccionPosterior()
        {
            FormPrincipal.getInstancia().InitializeAdminPerfiles();
        }
    }
}
