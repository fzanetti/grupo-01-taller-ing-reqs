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

namespace SGGEA.UserControls
{
    public partial class SelFuncion : UserControl
    {
        private bool _seleccionado=false;
        private Funcion _funcion;
        
        public SelFuncion(Funcion funcion)
        {
            InitializeComponent();
            _funcion=funcion;
            lblFuncion.Text = _funcion.Nombre;
        }

        public SelFuncion()
        {
            InitializeComponent();
        }

        public Funcion getFuncion()
        {
            return _funcion;
        }

        [Description("Ancho del nombre de la funcion"), Category("AnchoNombre")]
        public int AnchoNombre
        {
            get { return lblFuncion.Size.Width; }
            set
            {
                lblFuncion.Size = new System.Drawing.Size(value, lblFuncion.Size.Height);
                lblFuncion.MinimumSize = new System.Drawing.Size(value, lblFuncion.MinimumSize.Height);
                lblFuncion.MaximumSize = new System.Drawing.Size(value, lblFuncion.MaximumSize.Height);
            }
        }

        public bool Seleccionado
        {
            get { return _seleccionado;}
            set
            {
                _seleccionado = value;
                if (_seleccionado)
                {
                    this.btnFuncion.BackgroundImage = global::SGGEA.Properties.Resources.checkBoxChequed;
                }
                else
                {
                    this.btnFuncion.BackgroundImage = global::SGGEA.Properties.Resources.checkBox;
                }
            }
        }

        private void btnFuncion_Click(object sender, EventArgs e)
        {
            Seleccionado = !Seleccionado;
        }
    }
}
