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
    public partial class Toast : UserControl
    {
        public Toast()
        {
            InitializeComponent();
        }

        [Description("Texto del Mensaje"), Category("TextoMensaje")]
        public string TextoMensaje
        {
            get { return txtMensaje.Text; }
            set { txtMensaje.Text = value; }
        }
    }
}
