using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGGEA.UserControls
{
    public partial class ConfirmationDialog : UserControl
    {
        public ConfirmationDialog()
        {
            InitializeComponent();
        }

        [Description("Texto del Mensaje"), Category("TextoMensaje")]
        public string TextoMensaje
        {
            get { return mensaje.Text; }
            set { mensaje.Text = value; }
        }

        [Description("Texto del boton Aceptar"), Category("TextoBtnAceptar")]
        public string TextoAceptar
        {
            get { return btnAceptar.Text; }
            set { btnAceptar.Text = value; }
        }

        [Description("Texto del boton Cancelar"), Category("TextoBtnCancelar")]
        public string TextoCancelar
        {
            get { return btnCancelar.Text; }
            set { btnCancelar.Text = value; }
        }

        [Description("Posicion del boton Aceptar"), Category("PosicionBtnAceptar")]
        public DockStyle PosicionBtnAceptar
        {
            get { return btnAceptar.Dock; }
            set { btnAceptar.Dock = value; }
        }

        [Description("Posicion del boton Cancelar"), Category("PosicionBtnCancelar")]
        public DockStyle PosicionBtnCancelar
        {
            get { return btnCancelar.Dock; }
            set { btnCancelar.Dock = value; }
        }

        public delegate void FuncionDelEventoAceptar(object sender, EventArgs e);
        public void setConfirmationClickEvent(FuncionDelEventoAceptar f)
        {
           this.btnAceptar.Click += new System.EventHandler(f);       
        }

        public delegate void FuncionDelEventoCancelar(object sender, EventArgs e);
        public void setCancelClickEvent(FuncionDelEventoCancelar f)
        {
            this.btnCancelar.Click += new System.EventHandler(f);
        }

    }
}
