using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGGEA
{
    public partial class FormPrincipal : Form
    {
        private static FormPrincipal singleton;

        public static FormPrincipal getInstancia(){
            if (singleton == null)
                singleton = new FormPrincipal();
            return singleton;
        }

        private FormPrincipal()
        {
            InitializeComponent();
        }
    }
}
